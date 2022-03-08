<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDigitalDistrictOrgInfoRequest extends Model
{
    /**
     * @var string[]
     */
    public $corpIds;

    /**
     * @var string[]
     */
    public $statDates;
    protected $_name = [
        'corpIds'   => 'corpIds',
        'statDates' => 'statDates',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpIds) {
            $res['corpIds'] = $this->corpIds;
        }
        if (null !== $this->statDates) {
            $res['statDates'] = $this->statDates;
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
        if (isset($map['corpIds'])) {
            if (!empty($map['corpIds'])) {
                $model->corpIds = $map['corpIds'];
            }
        }
        if (isset($map['statDates'])) {
            if (!empty($map['statDates'])) {
                $model->statDates = $map['statDates'];
            }
        }

        return $model;
    }
}
