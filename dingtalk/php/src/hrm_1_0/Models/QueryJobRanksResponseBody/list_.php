<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobRanksResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 职级ID
     *
     * @var string
     */
    public $rankId;

    /**
     * @description 职级序列ID
     *
     * @var string
     */
    public $rankCategoryId;

    /**
     * @description 职级编码
     *
     * @var string
     */
    public $rankCode;

    /**
     * @description 职级名称
     *
     * @var string
     */
    public $rankName;

    /**
     * @description 最小等级
     *
     * @var int
     */
    public $minJobGrade;

    /**
     * @description 最大等级
     *
     * @var int
     */
    public $maxJobGrade;

    /**
     * @description 职级描述
     *
     * @var string
     */
    public $rankDescription;
    protected $_name = [
        'rankId'          => 'rankId',
        'rankCategoryId'  => 'rankCategoryId',
        'rankCode'        => 'rankCode',
        'rankName'        => 'rankName',
        'minJobGrade'     => 'minJobGrade',
        'maxJobGrade'     => 'maxJobGrade',
        'rankDescription' => 'rankDescription',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->rankId) {
            $res['rankId'] = $this->rankId;
        }
        if (null !== $this->rankCategoryId) {
            $res['rankCategoryId'] = $this->rankCategoryId;
        }
        if (null !== $this->rankCode) {
            $res['rankCode'] = $this->rankCode;
        }
        if (null !== $this->rankName) {
            $res['rankName'] = $this->rankName;
        }
        if (null !== $this->minJobGrade) {
            $res['minJobGrade'] = $this->minJobGrade;
        }
        if (null !== $this->maxJobGrade) {
            $res['maxJobGrade'] = $this->maxJobGrade;
        }
        if (null !== $this->rankDescription) {
            $res['rankDescription'] = $this->rankDescription;
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
        if (isset($map['rankId'])) {
            $model->rankId = $map['rankId'];
        }
        if (isset($map['rankCategoryId'])) {
            $model->rankCategoryId = $map['rankCategoryId'];
        }
        if (isset($map['rankCode'])) {
            $model->rankCode = $map['rankCode'];
        }
        if (isset($map['rankName'])) {
            $model->rankName = $map['rankName'];
        }
        if (isset($map['minJobGrade'])) {
            $model->minJobGrade = $map['minJobGrade'];
        }
        if (isset($map['maxJobGrade'])) {
            $model->maxJobGrade = $map['maxJobGrade'];
        }
        if (isset($map['rankDescription'])) {
            $model->rankDescription = $map['rankDescription'];
        }

        return $model;
    }
}
