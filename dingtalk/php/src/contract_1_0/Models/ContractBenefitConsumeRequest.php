<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class ContractBenefitConsumeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example esign
     *
     * @var string
     */
    public $benefitPoint;

    /**
     * @description This parameter is required.
     *
     * @example sjdaujii129w9qej2nqas
     *
     * @var string
     */
    public $bizRequestId;

    /**
     * @description This parameter is required.
     *
     * @example 20
     *
     * @var int
     */
    public $consumeQuota;

    /**
     * @description This parameter is required.
     *
     * @example ding1231ndu29923312
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $extParams;

    /**
     * @description This parameter is required.
     *
     * @example ding12939912nduaejjwe
     *
     * @var string
     */
    public $isvCorpId;

    /**
     * @example djauihjauiwnkndjknkjanaae
     *
     * @var string
     */
    public $optUnionId;
    protected $_name = [
        'benefitPoint' => 'benefitPoint',
        'bizRequestId' => 'bizRequestId',
        'consumeQuota' => 'consumeQuota',
        'corpId'       => 'corpId',
        'extParams'    => 'extParams',
        'isvCorpId'    => 'isvCorpId',
        'optUnionId'   => 'optUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitPoint) {
            $res['benefitPoint'] = $this->benefitPoint;
        }
        if (null !== $this->bizRequestId) {
            $res['bizRequestId'] = $this->bizRequestId;
        }
        if (null !== $this->consumeQuota) {
            $res['consumeQuota'] = $this->consumeQuota;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extParams) {
            $res['extParams'] = $this->extParams;
        }
        if (null !== $this->isvCorpId) {
            $res['isvCorpId'] = $this->isvCorpId;
        }
        if (null !== $this->optUnionId) {
            $res['optUnionId'] = $this->optUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ContractBenefitConsumeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitPoint'])) {
            $model->benefitPoint = $map['benefitPoint'];
        }
        if (isset($map['bizRequestId'])) {
            $model->bizRequestId = $map['bizRequestId'];
        }
        if (isset($map['consumeQuota'])) {
            $model->consumeQuota = $map['consumeQuota'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extParams'])) {
            $model->extParams = $map['extParams'];
        }
        if (isset($map['isvCorpId'])) {
            $model->isvCorpId = $map['isvCorpId'];
        }
        if (isset($map['optUnionId'])) {
            $model->optUnionId = $map['optUnionId'];
        }

        return $model;
    }
}
