<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveFormInstanceRequest\formComponentValueList;
use AlibabaCloud\Tea\Model;

class PremiumSaveFormInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var formComponentValueList[]
     */
    public $formComponentValueList;

    /**
     * @description This parameter is required.
     *
     * @example manager432
     *
     * @var string
     */
    public $originatorUserId;

    /**
     * @description This parameter is required.
     *
     * @example PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1
     *
     * @var string
     */
    public $processCode;
    protected $_name = [
        'formComponentValueList' => 'formComponentValueList',
        'originatorUserId' => 'originatorUserId',
        'processCode' => 'processCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->formComponentValueList) {
            $res['formComponentValueList'] = [];
            if (null !== $this->formComponentValueList && \is_array($this->formComponentValueList)) {
                $n = 0;
                foreach ($this->formComponentValueList as $item) {
                    $res['formComponentValueList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->originatorUserId) {
            $res['originatorUserId'] = $this->originatorUserId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumSaveFormInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formComponentValueList'])) {
            if (!empty($map['formComponentValueList'])) {
                $model->formComponentValueList = [];
                $n = 0;
                foreach ($map['formComponentValueList'] as $item) {
                    $model->formComponentValueList[$n++] = null !== $item ? formComponentValueList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['originatorUserId'])) {
            $model->originatorUserId = $map['originatorUserId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }

        return $model;
    }
}
