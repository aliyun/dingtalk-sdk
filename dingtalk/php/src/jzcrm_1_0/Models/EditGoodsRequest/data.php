<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditGoodsRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $addedtime;

    /**
     * @var string
     */
    public $cbprice;

    /**
     * @var string
     */
    public $cpParentid;

    /**
     * @var string
     */
    public $cparea;

    /**
     * @var string
     */
    public $cpbarcode;

    /**
     * @var string
     */
    public $cpbrand;

    /**
     * @var string
     */
    public $cpcontent;

    /**
     * @var string
     */
    public $cpguige;

    /**
     * @var string
     */
    public $cpimg;

    /**
     * @var string
     */
    public $cpname;

    /**
     * @var string
     */
    public $cpno;

    /**
     * @var string
     */
    public $cpremark;

    /**
     * @var string
     */
    public $cptype;

    /**
     * @var string
     */
    public $cpunit;

    /**
     * @var string
     */
    public $cpweight;

    /**
     * @example 张三
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @var string
     */
    public $gysid;

    /**
     * @var string
     */
    public $ispicimanage;

    /**
     * @var string
     */
    public $issnmanage;

    /**
     * @var string
     */
    public $isstock;

    /**
     * @var string
     */
    public $isstop;

    /**
     * @var string
     */
    public $preprice1;

    /**
     * @var string
     */
    public $preprice2;

    /**
     * @var string
     */
    public $preprice3;

    /**
     * @var string
     */
    public $preprice4;

    /**
     * @var string
     */
    public $stockdown;

    /**
     * @var string
     */
    public $stockup;

    /**
     * @var string
     */
    public $typeid;

    /**
     * @var string
     */
    public $unitrate;
    protected $_name = [
        'addedtime'    => 'addedtime',
        'cbprice'      => 'cbprice',
        'cpParentid'   => 'cp_parentid',
        'cparea'       => 'cparea',
        'cpbarcode'    => 'cpbarcode',
        'cpbrand'      => 'cpbrand',
        'cpcontent'    => 'cpcontent',
        'cpguige'      => 'cpguige',
        'cpimg'        => 'cpimg',
        'cpname'       => 'cpname',
        'cpno'         => 'cpno',
        'cpremark'     => 'cpremark',
        'cptype'       => 'cptype',
        'cpunit'       => 'cpunit',
        'cpweight'     => 'cpweight',
        'dataUserid'   => 'data_userid',
        'gysid'        => 'gysid',
        'ispicimanage' => 'ispicimanage',
        'issnmanage'   => 'issnmanage',
        'isstock'      => 'isstock',
        'isstop'       => 'isstop',
        'preprice1'    => 'preprice1',
        'preprice2'    => 'preprice2',
        'preprice3'    => 'preprice3',
        'preprice4'    => 'preprice4',
        'stockdown'    => 'stockdown',
        'stockup'      => 'stockup',
        'typeid'       => 'typeid',
        'unitrate'     => 'unitrate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->addedtime) {
            $res['addedtime'] = $this->addedtime;
        }
        if (null !== $this->cbprice) {
            $res['cbprice'] = $this->cbprice;
        }
        if (null !== $this->cpParentid) {
            $res['cp_parentid'] = $this->cpParentid;
        }
        if (null !== $this->cparea) {
            $res['cparea'] = $this->cparea;
        }
        if (null !== $this->cpbarcode) {
            $res['cpbarcode'] = $this->cpbarcode;
        }
        if (null !== $this->cpbrand) {
            $res['cpbrand'] = $this->cpbrand;
        }
        if (null !== $this->cpcontent) {
            $res['cpcontent'] = $this->cpcontent;
        }
        if (null !== $this->cpguige) {
            $res['cpguige'] = $this->cpguige;
        }
        if (null !== $this->cpimg) {
            $res['cpimg'] = $this->cpimg;
        }
        if (null !== $this->cpname) {
            $res['cpname'] = $this->cpname;
        }
        if (null !== $this->cpno) {
            $res['cpno'] = $this->cpno;
        }
        if (null !== $this->cpremark) {
            $res['cpremark'] = $this->cpremark;
        }
        if (null !== $this->cptype) {
            $res['cptype'] = $this->cptype;
        }
        if (null !== $this->cpunit) {
            $res['cpunit'] = $this->cpunit;
        }
        if (null !== $this->cpweight) {
            $res['cpweight'] = $this->cpweight;
        }
        if (null !== $this->dataUserid) {
            $res['data_userid'] = $this->dataUserid;
        }
        if (null !== $this->gysid) {
            $res['gysid'] = $this->gysid;
        }
        if (null !== $this->ispicimanage) {
            $res['ispicimanage'] = $this->ispicimanage;
        }
        if (null !== $this->issnmanage) {
            $res['issnmanage'] = $this->issnmanage;
        }
        if (null !== $this->isstock) {
            $res['isstock'] = $this->isstock;
        }
        if (null !== $this->isstop) {
            $res['isstop'] = $this->isstop;
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
        if (null !== $this->stockdown) {
            $res['stockdown'] = $this->stockdown;
        }
        if (null !== $this->stockup) {
            $res['stockup'] = $this->stockup;
        }
        if (null !== $this->typeid) {
            $res['typeid'] = $this->typeid;
        }
        if (null !== $this->unitrate) {
            $res['unitrate'] = $this->unitrate;
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
        if (isset($map['addedtime'])) {
            $model->addedtime = $map['addedtime'];
        }
        if (isset($map['cbprice'])) {
            $model->cbprice = $map['cbprice'];
        }
        if (isset($map['cp_parentid'])) {
            $model->cpParentid = $map['cp_parentid'];
        }
        if (isset($map['cparea'])) {
            $model->cparea = $map['cparea'];
        }
        if (isset($map['cpbarcode'])) {
            $model->cpbarcode = $map['cpbarcode'];
        }
        if (isset($map['cpbrand'])) {
            $model->cpbrand = $map['cpbrand'];
        }
        if (isset($map['cpcontent'])) {
            $model->cpcontent = $map['cpcontent'];
        }
        if (isset($map['cpguige'])) {
            $model->cpguige = $map['cpguige'];
        }
        if (isset($map['cpimg'])) {
            $model->cpimg = $map['cpimg'];
        }
        if (isset($map['cpname'])) {
            $model->cpname = $map['cpname'];
        }
        if (isset($map['cpno'])) {
            $model->cpno = $map['cpno'];
        }
        if (isset($map['cpremark'])) {
            $model->cpremark = $map['cpremark'];
        }
        if (isset($map['cptype'])) {
            $model->cptype = $map['cptype'];
        }
        if (isset($map['cpunit'])) {
            $model->cpunit = $map['cpunit'];
        }
        if (isset($map['cpweight'])) {
            $model->cpweight = $map['cpweight'];
        }
        if (isset($map['data_userid'])) {
            $model->dataUserid = $map['data_userid'];
        }
        if (isset($map['gysid'])) {
            $model->gysid = $map['gysid'];
        }
        if (isset($map['ispicimanage'])) {
            $model->ispicimanage = $map['ispicimanage'];
        }
        if (isset($map['issnmanage'])) {
            $model->issnmanage = $map['issnmanage'];
        }
        if (isset($map['isstock'])) {
            $model->isstock = $map['isstock'];
        }
        if (isset($map['isstop'])) {
            $model->isstop = $map['isstop'];
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
        if (isset($map['stockdown'])) {
            $model->stockdown = $map['stockdown'];
        }
        if (isset($map['stockup'])) {
            $model->stockup = $map['stockup'];
        }
        if (isset($map['typeid'])) {
            $model->typeid = $map['typeid'];
        }
        if (isset($map['unitrate'])) {
            $model->unitrate = $map['unitrate'];
        }

        return $model;
    }
}
