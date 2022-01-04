<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class contractInfo extends Model
{
    /**
     * @description 联系人姓名
     *
     * @var string
     */
    public $contractName;

    /**
     * @description 联系人手机号
     *
     * @var string
     */
    public $mobile;
    protected $_name = [
        'contractName' => 'contractName',
        'mobile'       => 'mobile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractName) {
            $res['contractName'] = $this->contractName;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contractInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contractName'])) {
            $model->contractName = $map['contractName'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }

        return $model;
    }
}
