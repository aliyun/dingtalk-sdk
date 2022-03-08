<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubCorpsResponseBody;

use AlibabaCloud\Tea\Model;

class corpList extends Model
{
    /**
     * @description 组织corpid
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 组织名字
     *
     * @var string
     */
    public $corpName;

    /**
     * @description 组织行业名称
     *
     * @var string
     */
    public $industry;

    /**
     * @description 组织行业码
     *
     * @var int
     */
    public $industryCode;

    /**
     * @description 区域码
     *
     * @var string
     */
    public $regionId;

    /**
     * @description 区域详细信息
     *
     * @var string
     */
    public $regionLocation;

    /**
     * @description 区域类型，值为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区
     *
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
