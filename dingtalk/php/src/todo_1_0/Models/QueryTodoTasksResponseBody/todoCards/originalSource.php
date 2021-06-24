<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards;

use AlibabaCloud\Tea\Model;

class originalSource extends Model
{
    /**
     * @description 业务来源展示名称
     *
     * @var string
     */
    public $sourceTitle;
    protected $_name = [
        'sourceTitle' => 'sourceTitle',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sourceTitle) {
            $res['sourceTitle'] = $this->sourceTitle;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return originalSource
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sourceTitle'])) {
            $model->sourceTitle = $map['sourceTitle'];
        }

        return $model;
    }
}
