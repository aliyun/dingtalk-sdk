<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest\detail\messageBody;

use AlibabaCloud\Tea\Model;

class markdown extends Model
{
    /**
     * @description markdown格式的消息，建议500字符以内。
     *
     * @var string
     */
    public $text;

    /**
     * @description 首屏会话透出的展示内容。
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'text'  => 'text',
        'title' => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return markdown
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
