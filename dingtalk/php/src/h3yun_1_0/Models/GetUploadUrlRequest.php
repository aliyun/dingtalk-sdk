<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUploadUrlRequest extends Model
{
    /**
     * @description 业务数据实例id
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @description 文件上传至目标控件的字段名
     *
     * @var string
     */
    public $fieldName;

    /**
     * @description 是否覆盖。false=添加，true=覆盖
     *
     * @var bool
     */
    public $isOverwrite;

    /**
     * @description 表单编码
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
