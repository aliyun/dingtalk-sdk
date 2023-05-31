<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAppResourceUseInfoRequest extends Model
{
    /**
     * @example api_count
     *
     * @var string
     */
    public $benefitCode;

    /**
     * @example 202302
     *
     * @var string
     */
    public $endTime;

    /**
     * @example month
     *
     * @var string
     */
    public $periodType;

    /**
     * @example 202301
     *
     * @var string
     */
    public $startTime;
    protected $_name = [
        'benefitCode' => 'benefitCode',
        'endTime'     => 'endTime',
        'periodType'  => 'periodType',
        'startTime'   => 'startTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitCode) {
            $res['benefitCode'] = $this->benefitCode;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->periodType) {
            $res['periodType'] = $this->periodType;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAppResourceUseInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitCode'])) {
            $model->benefitCode = $map['benefitCode'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['periodType'])) {
            $model->periodType = $map['periodType'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
