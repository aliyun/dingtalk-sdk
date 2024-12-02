<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoAddKnowledgeGraphRelationRequest;

use AlibabaCloud\Tea\Model;

class relationInfo extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example xxxx
     *
     * @var string
     */
    public $endId;

    /**
     * @example {"年龄"：43}
     *
     * @var string
     */
    public $propertiesString;

    /**
     * @description This parameter is required.
     *
     * @example 出生于
     *
     * @var string
     */
    public $relationName;

    /**
     * @description This parameter is required.
     *
     * @example xxxxx
     *
     * @var string
     */
    public $startId;
    protected $_name = [
        'endId'            => 'endId',
        'propertiesString' => 'propertiesString',
        'relationName'     => 'relationName',
        'startId'          => 'startId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endId) {
            $res['endId'] = $this->endId;
        }
        if (null !== $this->propertiesString) {
            $res['propertiesString'] = $this->propertiesString;
        }
        if (null !== $this->relationName) {
            $res['relationName'] = $this->relationName;
        }
        if (null !== $this->startId) {
            $res['startId'] = $this->startId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relationInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endId'])) {
            $model->endId = $map['endId'];
        }
        if (isset($map['propertiesString'])) {
            $model->propertiesString = $map['propertiesString'];
        }
        if (isset($map['relationName'])) {
            $model->relationName = $map['relationName'];
        }
        if (isset($map['startId'])) {
            $model->startId = $map['startId'];
        }

        return $model;
    }
}
