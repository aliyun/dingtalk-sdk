<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobRanksResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 30
     *
     * @var int
     */
    public $maxJobGrade;

    /**
     * @example 1
     *
     * @var int
     */
    public $minJobGrade;

    /**
     * @var string
     */
    public $rankCategoryId;

    /**
     * @var string
     */
    public $rankCode;

    /**
     * @var string
     */
    public $rankDescription;

    /**
     * @var string
     */
    public $rankId;

    /**
     * @var string
     */
    public $rankName;
    protected $_name = [
        'maxJobGrade'     => 'maxJobGrade',
        'minJobGrade'     => 'minJobGrade',
        'rankCategoryId'  => 'rankCategoryId',
        'rankCode'        => 'rankCode',
        'rankDescription' => 'rankDescription',
        'rankId'          => 'rankId',
        'rankName'        => 'rankName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxJobGrade) {
            $res['maxJobGrade'] = $this->maxJobGrade;
        }
        if (null !== $this->minJobGrade) {
            $res['minJobGrade'] = $this->minJobGrade;
        }
        if (null !== $this->rankCategoryId) {
            $res['rankCategoryId'] = $this->rankCategoryId;
        }
        if (null !== $this->rankCode) {
            $res['rankCode'] = $this->rankCode;
        }
        if (null !== $this->rankDescription) {
            $res['rankDescription'] = $this->rankDescription;
        }
        if (null !== $this->rankId) {
            $res['rankId'] = $this->rankId;
        }
        if (null !== $this->rankName) {
            $res['rankName'] = $this->rankName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxJobGrade'])) {
            $model->maxJobGrade = $map['maxJobGrade'];
        }
        if (isset($map['minJobGrade'])) {
            $model->minJobGrade = $map['minJobGrade'];
        }
        if (isset($map['rankCategoryId'])) {
            $model->rankCategoryId = $map['rankCategoryId'];
        }
        if (isset($map['rankCode'])) {
            $model->rankCode = $map['rankCode'];
        }
        if (isset($map['rankDescription'])) {
            $model->rankDescription = $map['rankDescription'];
        }
        if (isset($map['rankId'])) {
            $model->rankId = $map['rankId'];
        }
        if (isset($map['rankName'])) {
            $model->rankName = $map['rankName'];
        }

        return $model;
    }
}
