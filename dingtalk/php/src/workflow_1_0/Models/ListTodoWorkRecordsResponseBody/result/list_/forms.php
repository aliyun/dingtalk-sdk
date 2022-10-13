<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListTodoWorkRecordsResponseBody\result\list_;

use AlibabaCloud\Tea\Model;

class forms extends Model
{
    /**
     * @description 表单内容。
     *
     * @var string
     */
    public $content;

    /**
     * @description 表单标题。
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'content' => 'content',
        'title'   => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return forms
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
