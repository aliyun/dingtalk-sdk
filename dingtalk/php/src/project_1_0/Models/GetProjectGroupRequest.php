<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProjectGroupRequest extends Model
{
    /**
     * @description 分页大小，最小1，默认10，最大1000
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 查看者ID
     *
     * @var string
     */
    public $viewerId;
    protected $_name = [
        'pageSize' => 'pageSize',
        'viewerId' => 'viewerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->viewerId) {
            $res['viewerId'] = $this->viewerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProjectGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['viewerId'])) {
            $model->viewerId = $map['viewerId'];
        }

        return $model;
    }
}
