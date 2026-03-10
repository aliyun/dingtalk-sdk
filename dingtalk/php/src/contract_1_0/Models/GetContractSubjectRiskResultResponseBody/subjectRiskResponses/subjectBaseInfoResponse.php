<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody\subjectRiskResponses;

use AlibabaCloud\Tea\Model;

class subjectBaseInfoResponse extends Model
{
    /**
     * @var string
     */
    public $creditCode;

    /**
     * @var int
     */
    public $establishTime;

    /**
     * @var string
     */
    public $legalPersonName;

    /**
     * @var string
     */
    public $regLocation;
    protected $_name = [
        'creditCode' => 'creditCode',
        'establishTime' => 'establishTime',
        'legalPersonName' => 'legalPersonName',
        'regLocation' => 'regLocation',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creditCode) {
            $res['creditCode'] = $this->creditCode;
        }
        if (null !== $this->establishTime) {
            $res['establishTime'] = $this->establishTime;
        }
        if (null !== $this->legalPersonName) {
            $res['legalPersonName'] = $this->legalPersonName;
        }
        if (null !== $this->regLocation) {
            $res['regLocation'] = $this->regLocation;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subjectBaseInfoResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creditCode'])) {
            $model->creditCode = $map['creditCode'];
        }
        if (isset($map['establishTime'])) {
            $model->establishTime = $map['establishTime'];
        }
        if (isset($map['legalPersonName'])) {
            $model->legalPersonName = $map['legalPersonName'];
        }
        if (isset($map['regLocation'])) {
            $model->regLocation = $map['regLocation'];
        }

        return $model;
    }
}
