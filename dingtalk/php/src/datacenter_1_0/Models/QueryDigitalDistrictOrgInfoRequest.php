<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDigitalDistrictOrgInfoRequest extends Model
{
    /**
     * @var string
     */
    public $kpiGroupId;

    /**
     * @var string[]
     */
    public $statDates;

    /**
     * @var string[]
     */
    public $corpIds;
    protected $_name = [
        'kpiGroupId' => 'kpiGroupId',
        'statDates'  => 'statDates',
        'corpIds'    => 'corpIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->kpiGroupId) {
            $res['kpiGroupId'] = $this->kpiGroupId;
        }
        if (null !== $this->statDates) {
            $res['statDates'] = $this->statDates;
        }
        if (null !== $this->corpIds) {
            $res['corpIds'] = $this->corpIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDigitalDistrictOrgInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['kpiGroupId'])) {
            $model->kpiGroupId = $map['kpiGroupId'];
        }
        if (isset($map['statDates'])) {
            if (!empty($map['statDates'])) {
                $model->statDates = $map['statDates'];
            }
        }
        if (isset($map['corpIds'])) {
            if (!empty($map['corpIds'])) {
                $model->corpIds = $map['corpIds'];
            }
        }

        return $model;
    }
}
