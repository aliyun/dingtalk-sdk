<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubCorpsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 企业corpid
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 企业名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 区域类型，值为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区
     *
     * @var string
     */
    public $regionType;

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
     * @description 企业行业码
     *
     * @var int
     */
    public $industryCode;

    /**
     * @description 企业行业名称
     *
     * @var string
     */
    public $industry;
    protected $_name = [
        'corpId'         => 'corpId',
        'name'           => 'name',
        'regionType'     => 'regionType',
        'regionId'       => 'regionId',
        'regionLocation' => 'regionLocation',
        'industryCode'   => 'industryCode',
        'industry'       => 'industry',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->regionType) {
            $res['regionType'] = $this->regionType;
        }
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
        }
        if (null !== $this->regionLocation) {
            $res['regionLocation'] = $this->regionLocation;
        }
        if (null !== $this->industryCode) {
            $res['industryCode'] = $this->industryCode;
        }
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['regionType'])) {
            $model->regionType = $map['regionType'];
        }
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }
        if (isset($map['regionLocation'])) {
            $model->regionLocation = $map['regionLocation'];
        }
        if (isset($map['industryCode'])) {
            $model->industryCode = $map['industryCode'];
        }
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }

        return $model;
    }
}
