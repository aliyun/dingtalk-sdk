<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateFinanceCompanyInfoRequest extends Model
{
    /**
     * @description 公司名字
     *
     * @var string
     */
    public $companyName;

    /**
     * @description 纳税性质 小规模纳税人 一般纳税人
     *
     * @var string
     */
    public $taxNature;

    /**
     * @description 税号
     *
     * @var string
     */
    public $taxNo;

    /**
     * @description 用户ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'companyName' => 'companyName',
        'taxNature'   => 'taxNature',
        'taxNo'       => 'taxNo',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyName) {
            $res['companyName'] = $this->companyName;
        }
        if (null !== $this->taxNature) {
            $res['taxNature'] = $this->taxNature;
        }
        if (null !== $this->taxNo) {
            $res['taxNo'] = $this->taxNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFinanceCompanyInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyName'])) {
            $model->companyName = $map['companyName'];
        }
        if (isset($map['taxNature'])) {
            $model->taxNature = $map['taxNature'];
        }
        if (isset($map['taxNo'])) {
            $model->taxNo = $map['taxNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
