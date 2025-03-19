<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CreateBizObjectResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 50599800-af82-487e-9386-0a7278cab69f
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @example DataList
     *
     * @var string
     */
    public $formUsageType;

    /**
     * @example 3b5451bc-9fd3-4d0c-ba47-191f8bff95ab
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example D0001839bbbbe346bbf496498bb76c44c7eb972
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectId' => 'bizObjectId',
        'formUsageType' => 'formUsageType',
        'processInstanceId' => 'processInstanceId',
        'schemaCode' => 'schemaCode',
    ];

    public function validate() {}

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
