<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\dataSource;

use AlibabaCloud\Tea\Model;

class target extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $appType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $formCode;
    protected $_name = [
        'appType' => 'appType',
        'appUuid' => 'appUuid',
        'bizType' => 'bizType',
        'formCode' => 'formCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return target
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }

        return $model;
    }
}
