<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatAIListDatasetResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $datasetDesc;

    /**
     * @var int
     */
    public $datasetId;

    /**
     * @var string
     */
    public $datasetName;

    /**
     * @var string
     */
    public $memoType;

    /**
     * @var string
     */
    public $resourceType;
    protected $_name = [
        'datasetDesc'  => 'datasetDesc',
        'datasetId'    => 'datasetId',
        'datasetName'  => 'datasetName',
        'memoType'     => 'memoType',
        'resourceType' => 'resourceType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->datasetDesc) {
            $res['datasetDesc'] = $this->datasetDesc;
        }
        if (null !== $this->datasetId) {
            $res['datasetId'] = $this->datasetId;
        }
        if (null !== $this->datasetName) {
            $res['datasetName'] = $this->datasetName;
        }
        if (null !== $this->memoType) {
            $res['memoType'] = $this->memoType;
        }
        if (null !== $this->resourceType) {
            $res['resourceType'] = $this->resourceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['datasetDesc'])) {
            $model->datasetDesc = $map['datasetDesc'];
        }
        if (isset($map['datasetId'])) {
            $model->datasetId = $map['datasetId'];
        }
        if (isset($map['datasetName'])) {
            $model->datasetName = $map['datasetName'];
        }
        if (isset($map['memoType'])) {
            $model->memoType = $map['memoType'];
        }
        if (isset($map['resourceType'])) {
            $model->resourceType = $map['resourceType'];
        }

        return $model;
    }
}
