<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class BatchDeleteRecentsRequest extends Model
{
    /**
     * @description 移除最近记录文档uuid
     * 20
     * @var string[]
     */
    public $dentryUuids;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'dentryUuids' => 'dentryUuids',
        'operatorId'  => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryUuids) {
            $res['dentryUuids'] = $this->dentryUuids;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchDeleteRecentsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryUuids'])) {
            if (!empty($map['dentryUuids'])) {
                $model->dentryUuids = $map['dentryUuids'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
