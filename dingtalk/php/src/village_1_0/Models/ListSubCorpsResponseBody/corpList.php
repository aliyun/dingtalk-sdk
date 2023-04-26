<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubCorpsResponseBody;

use AlibabaCloud\Tea\Model;

class corpList extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $corpName;

    /**
     * @var string
     */
    public $industry;

    /**
     * @example 149 区县，148 乡镇街道，145 村， 150 社区， 151 小区
     *
     * @var int
     */
    public $industryCode;

    /**
     * @var string
     */
    public $regionId;

    /**
     * @example 浙江省_杭州市_余杭区_仓前街道
     *
     * @var string
     */
    public $regionLocation;

    /**
     * @var string
     */
    public $regionType;
    protected $_name = [
        'corpId'         => 'corpId',
        'corpName'       => 'corpName',
        'industry'       => 'industry',
        'industryCode'   => 'industryCode',
        'regionId'       => 'regionId',
        'regionLocation' => 'regionLocation',
        'regionType'     => 'regionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }
        if (null !== $this->industryCode) {
            $res['industryCode'] = $this->industryCode;
        }
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
        }
        if (null !== $this->regionLocation) {
            $res['regionLocation'] = $this->regionLocation;
        }
        if (null !== $this->regionType) {
            $res['regionType'] = $this->regionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return corpList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }
        if (isset($map['industryCode'])) {
            $model->industryCode = $map['industryCode'];
        }
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }
        if (isset($map['regionLocation'])) {
            $model->regionLocation = $map['regionLocation'];
        }
        if (isset($map['regionType'])) {
            $model->regionType = $map['regionType'];
        }

        return $model;
    }
}
