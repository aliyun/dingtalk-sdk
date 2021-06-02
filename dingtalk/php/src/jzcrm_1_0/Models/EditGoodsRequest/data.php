<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditGoodsRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 创建人
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @description 产品名称
     *
     * @var string
     */
    public $cpname;

    /**
     * @description 产品单位
     *
     * @var string
     */
    public $cpunit;

    /**
     * @description 单位换算
     *
     * @var string
     */
    public $unitrate;

    /**
     * @description 基准产品
     *
     * @var string
     */
    public $cpParentid;

    /**
     * @description 产品型号
     *
     * @var string
     */
    public $cptype;

    /**
     * @description 产品规格
     *
     * @var string
     */
    public $cpguige;

    /**
     * @description 产品类别
     *
     * @var string
     */
    public $typeid;

    /**
     * @description 产品编号
     *
     * @var string
     */
    public $cpno;

    /**
     * @description 产品状态（正常，停售，下架）
     *
     * @var string
     */
    public $isstop;

    /**
     * @description 上架时间
     *
     * @var string
     */
    public $addedtime;

    /**
     * @description 产品产地
     *
     * @var string
     */
    public $cparea;

    /**
     * @description 产品品牌
     *
     * @var string
     */
    public $cpbrand;

    /**
     * @description 成本价格
     *
     * @var string
     */
    public $cbprice;

    /**
     * @description 序列号管理（是，否）
     *
     * @var string
     */
    public $issnmanage;

    /**
     * @description 批次号管理（是，否）
     *
     * @var string
     */
    public $ispicimanage;

    /**
     * @description 默认供应商
     *
     * @var string
     */
    public $gysid;

    /**
     * @description 产品图片
     *
     * @var string
     */
    public $cpimg;

    /**
     * @description 条形码
     *
     * @var string
     */
    public $cpbarcode;

    /**
     * @description 产品重量
     *
     * @var string
     */
    public $cpweight;

    /**
     * @description 零售价格
     *
     * @var string
     */
    public $preprice1;

    /**
     * @description 预设价格1
     *
     * @var string
     */
    public $preprice2;

    /**
     * @description 预设价格2
     *
     * @var string
     */
    public $preprice3;

    /**
     * @description 预设价格3
     *
     * @var string
     */
    public $preprice4;

    /**
     * @description 是否算库存（计算，不计算，计算(按基准规格)）
     *
     * @var string
     */
    public $isstock;

    /**
     * @description 库存上限
     *
     * @var string
     */
    public $stockup;

    /**
     * @description 库存下限
     *
     * @var string
     */
    public $stockdown;

    /**
     * @description 产品说明
     *
     * @var string
     */
    public $cpcontent;

    /**
     * @description 产品备注
     *
     * @var string
     */
    public $cpremark;
    protected $_name = [
        'dataUserid'   => 'data_userid',
        'cpname'       => 'cpname',
        'cpunit'       => 'cpunit',
        'unitrate'     => 'unitrate',
        'cpParentid'   => 'cp_parentid',
        'cptype'       => 'cptype',
        'cpguige'      => 'cpguige',
        'typeid'       => 'typeid',
        'cpno'         => 'cpno',
        'isstop'       => 'isstop',
        'addedtime'    => 'addedtime',
        'cparea'       => 'cparea',
        'cpbrand'      => 'cpbrand',
        'cbprice'      => 'cbprice',
        'issnmanage'   => 'issnmanage',
        'ispicimanage' => 'ispicimanage',
        'gysid'        => 'gysid',
        'cpimg'        => 'cpimg',
        'cpbarcode'    => 'cpbarcode',
        'cpweight'     => 'cpweight',
        'preprice1'    => 'preprice1',
        'preprice2'    => 'preprice2',
        'preprice3'    => 'preprice3',
        'preprice4'    => 'preprice4',
        'isstock'      => 'isstock',
        'stockup'      => 'stockup',
        'stockdown'    => 'stockdown',
        'cpcontent'    => 'cpcontent',
        'cpremark'     => 'cpremark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataUserid) {
            $res['data_userid'] = $this->dataUserid;
        }
        if (null !== $this->cpname) {
            $res['cpname'] = $this->cpname;
        }
        if (null !== $this->cpunit) {
            $res['cpunit'] = $this->cpunit;
        }
        if (null !== $this->unitrate) {
            $res['unitrate'] = $this->unitrate;
        }
        if (null !== $this->cpParentid) {
            $res['cp_parentid'] = $this->cpParentid;
        }
        if (null !== $this->cptype) {
            $res['cptype'] = $this->cptype;
        }
        if (null !== $this->cpguige) {
            $res['cpguige'] = $this->cpguige;
        }
        if (null !== $this->typeid) {
            $res['typeid'] = $this->typeid;
        }
        if (null !== $this->cpno) {
            $res['cpno'] = $this->cpno;
        }
        if (null !== $this->isstop) {
            $res['isstop'] = $this->isstop;
        }
        if (null !== $this->addedtime) {
            $res['addedtime'] = $this->addedtime;
        }
        if (null !== $this->cparea) {
            $res['cparea'] = $this->cparea;
        }
        if (null !== $this->cpbrand) {
            $res['cpbrand'] = $this->cpbrand;
        }
        if (null !== $this->cbprice) {
            $res['cbprice'] = $this->cbprice;
        }
        if (null !== $this->issnmanage) {
            $res['issnmanage'] = $this->issnmanage;
        }
        if (null !== $this->ispicimanage) {
            $res['ispicimanage'] = $this->ispicimanage;
        }
        if (null !== $this->gysid) {
            $res['gysid'] = $this->gysid;
        }
        if (null !== $this->cpimg) {
            $res['cpimg'] = $this->cpimg;
        }
        if (null !== $this->cpbarcode) {
            $res['cpbarcode'] = $this->cpbarcode;
        }
        if (null !== $this->cpweight) {
            $res['cpweight'] = $this->cpweight;
        }
        if (null !== $this->preprice1) {
            $res['preprice1'] = $this->preprice1;
        }
        if (null !== $this->preprice2) {
            $res['preprice2'] = $this->preprice2;
        }
        if (null !== $this->preprice3) {
            $res['preprice3'] = $this->preprice3;
        }
        if (null !== $this->preprice4) {
            $res['preprice4'] = $this->preprice4;
        }
        if (null !== $this->isstock) {
            $res['isstock'] = $this->isstock;
        }
        if (null !== $this->stockup) {
            $res['stockup'] = $this->stockup;
        }
        if (null !== $this->stockdown) {
            $res['stockdown'] = $this->stockdown;
        }
        if (null !== $this->cpcontent) {
            $res['cpcontent'] = $this->cpcontent;
        }
        if (null !== $this->cpremark) {
            $res['cpremark'] = $this->cpremark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data_userid'])) {
            $model->dataUserid = $map['data_userid'];
        }
        if (isset($map['cpname'])) {
            $model->cpname = $map['cpname'];
        }
        if (isset($map['cpunit'])) {
            $model->cpunit = $map['cpunit'];
        }
        if (isset($map['unitrate'])) {
            $model->unitrate = $map['unitrate'];
        }
        if (isset($map['cp_parentid'])) {
            $model->cpParentid = $map['cp_parentid'];
        }
        if (isset($map['cptype'])) {
            $model->cptype = $map['cptype'];
        }
        if (isset($map['cpguige'])) {
            $model->cpguige = $map['cpguige'];
        }
        if (isset($map['typeid'])) {
            $model->typeid = $map['typeid'];
        }
        if (isset($map['cpno'])) {
            $model->cpno = $map['cpno'];
        }
        if (isset($map['isstop'])) {
            $model->isstop = $map['isstop'];
        }
        if (isset($map['addedtime'])) {
            $model->addedtime = $map['addedtime'];
        }
        if (isset($map['cparea'])) {
            $model->cparea = $map['cparea'];
        }
        if (isset($map['cpbrand'])) {
            $model->cpbrand = $map['cpbrand'];
        }
        if (isset($map['cbprice'])) {
            $model->cbprice = $map['cbprice'];
        }
        if (isset($map['issnmanage'])) {
            $model->issnmanage = $map['issnmanage'];
        }
        if (isset($map['ispicimanage'])) {
            $model->ispicimanage = $map['ispicimanage'];
        }
        if (isset($map['gysid'])) {
            $model->gysid = $map['gysid'];
        }
        if (isset($map['cpimg'])) {
            $model->cpimg = $map['cpimg'];
        }
        if (isset($map['cpbarcode'])) {
            $model->cpbarcode = $map['cpbarcode'];
        }
        if (isset($map['cpweight'])) {
            $model->cpweight = $map['cpweight'];
        }
        if (isset($map['preprice1'])) {
            $model->preprice1 = $map['preprice1'];
        }
        if (isset($map['preprice2'])) {
            $model->preprice2 = $map['preprice2'];
        }
        if (isset($map['preprice3'])) {
            $model->preprice3 = $map['preprice3'];
        }
        if (isset($map['preprice4'])) {
            $model->preprice4 = $map['preprice4'];
        }
        if (isset($map['isstock'])) {
            $model->isstock = $map['isstock'];
        }
        if (isset($map['stockup'])) {
            $model->stockup = $map['stockup'];
        }
        if (isset($map['stockdown'])) {
            $model->stockdown = $map['stockdown'];
        }
        if (isset($map['cpcontent'])) {
            $model->cpcontent = $map['cpcontent'];
        }
        if (isset($map['cpremark'])) {
            $model->cpremark = $map['cpremark'];
        }

        return $model;
    }
}
