<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUploadUrlRequest extends Model
{
    /**
     * @example 006f870b-4d1c-4cd0-85b3-2e866798e947
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @example Image
     *
     * @var string
     */
    public $fieldName;

    /**
     * @example true
     *
     * @var bool
     */
    public $isOverwrite;

    /**
     * @example D0001833abb0fb61524487eb01848207bc89b47
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectId' => 'bizObjectId',
        'fieldName'   => 'fieldName',
        'isOverwrite' => 'isOverwrite',
        'schemaCode'  => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectId) {
            $res['bizObjectId'] = $this->bizObjectId;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->isOverwrite) {
            $res['isOverwrite'] = $this->isOverwrite;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUploadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['isOverwrite'])) {
            $model->isOverwrite = $map['isOverwrite'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
