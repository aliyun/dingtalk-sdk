<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChatAIQueryDatasetPermissionRequest extends Model
{
    /**
     * @example 数据集Id
     *
     * @var string
     */
    public $datasetId;
    protected $_name = [
        'datasetId' => 'datasetId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->datasetId) {
            $res['datasetId'] = $this->datasetId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatAIQueryDatasetPermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['datasetId'])) {
            $model->datasetId = $map['datasetId'];
        }

        return $model;
    }
}
