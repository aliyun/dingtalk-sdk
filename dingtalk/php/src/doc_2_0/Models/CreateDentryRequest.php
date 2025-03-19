<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreateDentryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example file
     *
     * @var string
     */
    public $dentryType;

    /**
     * @example 0
     *
     * @var int
     */
    public $documentType;

    /**
     * @description This parameter is required.
     *
     * @example dingtalk
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example abc
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example abcedf
     *
     * @var string
     */
    public $parentDentryId;
    protected $_name = [
        'dentryType' => 'dentryType',
        'documentType' => 'documentType',
        'name' => 'name',
        'operatorId' => 'operatorId',
        'parentDentryId' => 'parentDentryId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryType) {
            $res['dentryType'] = $this->dentryType;
        }
        if (null !== $this->documentType) {
            $res['documentType'] = $this->documentType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->parentDentryId) {
            $res['parentDentryId'] = $this->parentDentryId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateDentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryType'])) {
            $model->dentryType = $map['dentryType'];
        }
        if (isset($map['documentType'])) {
            $model->documentType = $map['documentType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['parentDentryId'])) {
            $model->parentDentryId = $map['parentDentryId'];
        }

        return $model;
    }
}
