<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class DocAppendParagraphRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example element_type
     *
     * @var string
     */
    public $elementType;

    /**
     * @description This parameter is required.
     *
     * @example properties
     *
     * @var mixed[]
     */
    public $properties;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'elementType' => 'elementType',
        'properties' => 'properties',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->elementType) {
            $res['elementType'] = $this->elementType;
        }
        if (null !== $this->properties) {
            $res['properties'] = $this->properties;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DocAppendParagraphRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['elementType'])) {
            $model->elementType = $map['elementType'];
        }
        if (isset($map['properties'])) {
            $model->properties = $map['properties'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
