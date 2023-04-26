<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryEmpPointDetailsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryEmpPointDetailsResponseBody\result\details\pointOperateFeatureResponseDTO;
use AlibabaCloud\Tea\Model;

class details extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $amount;

    /**
     * @example 1655450856000
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @example 324324353535
     *
     * @var string
     */
    public $outId;

    /**
     * @var pointOperateFeatureResponseDTO
     */
    public $pointOperateFeatureResponseDTO;

    /**
     * @example personal
     *
     * @var string
     */
    public $sourceBizCode;
    protected $_name = [
        'amount'                         => 'amount',
        'gmtCreate'                      => 'gmtCreate',
        'outId'                          => 'outId',
        'pointOperateFeatureResponseDTO' => 'pointOperateFeatureResponseDTO',
        'sourceBizCode'                  => 'sourceBizCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->outId) {
            $res['outId'] = $this->outId;
        }
        if (null !== $this->pointOperateFeatureResponseDTO) {
            $res['pointOperateFeatureResponseDTO'] = null !== $this->pointOperateFeatureResponseDTO ? $this->pointOperateFeatureResponseDTO->toMap() : null;
        }
        if (null !== $this->sourceBizCode) {
            $res['sourceBizCode'] = $this->sourceBizCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return details
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['outId'])) {
            $model->outId = $map['outId'];
        }
        if (isset($map['pointOperateFeatureResponseDTO'])) {
            $model->pointOperateFeatureResponseDTO = pointOperateFeatureResponseDTO::fromMap($map['pointOperateFeatureResponseDTO']);
        }
        if (isset($map['sourceBizCode'])) {
            $model->sourceBizCode = $map['sourceBizCode'];
        }

        return $model;
    }
}
