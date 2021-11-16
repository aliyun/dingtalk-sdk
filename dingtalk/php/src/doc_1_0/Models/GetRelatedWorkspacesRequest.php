<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRelatedWorkspacesRequest extends Model
{
    /**
     * @description 发起操作用户unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 是否查询最近访问文档列表
     *
     * @var bool
     */
    public $includeRecent;
    protected $_name = [
        'operatorId'    => 'operatorId',
        'includeRecent' => 'includeRecent',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->includeRecent) {
            $res['includeRecent'] = $this->includeRecent;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRelatedWorkspacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['includeRecent'])) {
            $model->includeRecent = $map['includeRecent'];
        }

        return $model;
    }
}
