<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CreateBizObjectResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 表单业务数据id
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @description 数据模型。DataList=本地存储的列表库，Workflow=工作流应用
     *
     * @var string
     */
    public $formUsageType;

    /**
     * @description 流程实例id
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectId'       => 'bizObjectId',
        'formUsageType'     => 'formUsageType',
        'processInstanceId' => 'processInstanceId',
        'schemaCode'        => 'schemaCode',
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
        if (null !== $this->formUsageType) {
            $res['formUsageType'] = $this->formUsageType;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }
        if (isset($map['formUsageType'])) {
            $model->formUsageType = $map['formUsageType'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
