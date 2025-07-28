<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenBenefitPackageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $benefitPackage;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $endDate;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startDate;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxx
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'benefitPackage' => 'benefitPackage',
        'endDate' => 'endDate',
        'startDate' => 'startDate',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitPackage) {
            $res['benefitPackage'] = $this->benefitPackage;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenBenefitPackageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitPackage'])) {
            $model->benefitPackage = $map['benefitPackage'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
