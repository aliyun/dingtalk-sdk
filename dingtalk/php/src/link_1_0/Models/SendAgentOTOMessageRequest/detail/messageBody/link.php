<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody;

use AlibabaCloud\Tea\Model;

class link extends Model
{
    /**
     * @example https://www.yourdomain.com
     *
     * @var string
     */
    public $messageUrl;

    /**
     * @example @1234-456
     *
     * @var string
     */
    public $picUrl;

    /**
     * @example 欢迎使用
     *
     * @var string
     */
    public $text;

    /**
     * @example 点击查看
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'messageUrl' => 'messageUrl',
        'picUrl' => 'picUrl',
        'text' => 'text',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageUrl) {
            $res['messageUrl'] = $this->messageUrl;
        }
        if (null !== $this->picUrl) {
            $res['picUrl'] = $this->picUrl;
        }
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
     * @return link
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageUrl'])) {
            $model->messageUrl = $map['messageUrl'];
        }
        if (isset($map['picUrl'])) {
            $model->picUrl = $map['picUrl'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
