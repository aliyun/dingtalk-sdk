<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListGroupTemplatesByOrgIdResponseBody\sceneGroupDetailModels;
use AlibabaCloud\Tea\Model;

class ListGroupTemplatesByOrgIdResponseBody extends Model
{
    /**
     * @var int
     */
    public $count;

    /**
     * @var sceneGroupDetailModels[]
     */
    public $sceneGroupDetailModels;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'count'                  => 'count',
        'sceneGroupDetailModels' => 'sceneGroupDetailModels',
        'success'                => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->sceneGroupDetailModels) {
            $res['sceneGroupDetailModels'] = [];
            if (null !== $this->sceneGroupDetailModels && \is_array($this->sceneGroupDetailModels)) {
                $n = 0;
                foreach ($this->sceneGroupDetailModels as $item) {
                    $res['sceneGroupDetailModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListGroupTemplatesByOrgIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['sceneGroupDetailModels'])) {
            if (!empty($map['sceneGroupDetailModels'])) {
                $model->sceneGroupDetailModels = [];
                $n                             = 0;
                foreach ($map['sceneGroupDetailModels'] as $item) {
                    $model->sceneGroupDetailModels[$n++] = null !== $item ? sceneGroupDetailModels::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
