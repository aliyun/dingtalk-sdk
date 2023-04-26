<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditProductionRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @var string
     */
    public $schCustomerid;

    /**
     * @var string
     */
    public $schEndtime;

    /**
     * @var string
     */
    public $schFinished;

    /**
     * @var string
     */
    public $schHtid;

    /**
     * @var string
     */
    public $schMakeemp;

    /**
     * @var string
     */
    public $schNumber;

    /**
     * @var string
     */
    public $schPlanendtime;

    /**
     * @var string
     */
    public $schPrincipal;

    /**
     * @var string
     */
    public $schRemark;

    /**
     * @var string
     */
    public $schStarttime;

    /**
     * @var string
     */
    public $schStatesstr;

    /**
     * @var string
     */
    public $schTitle;
    protected $_name = [
        'dataUserid'     => 'data_userid',
        'schCustomerid'  => 'sch_customerid',
        'schEndtime'     => 'sch_endtime',
        'schFinished'    => 'sch_finished',
        'schHtid'        => 'sch_htid',
        'schMakeemp'     => 'sch_makeemp',
        'schNumber'      => 'sch_number',
        'schPlanendtime' => 'sch_planendtime',
        'schPrincipal'   => 'sch_principal',
        'schRemark'      => 'sch_remark',
        'schStarttime'   => 'sch_starttime',
        'schStatesstr'   => 'sch_statesstr',
        'schTitle'       => 'sch_title',
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
        if (null !== $this->schCustomerid) {
            $res['sch_customerid'] = $this->schCustomerid;
        }
        if (null !== $this->schEndtime) {
            $res['sch_endtime'] = $this->schEndtime;
        }
        if (null !== $this->schFinished) {
            $res['sch_finished'] = $this->schFinished;
        }
        if (null !== $this->schHtid) {
            $res['sch_htid'] = $this->schHtid;
        }
        if (null !== $this->schMakeemp) {
            $res['sch_makeemp'] = $this->schMakeemp;
        }
        if (null !== $this->schNumber) {
            $res['sch_number'] = $this->schNumber;
        }
        if (null !== $this->schPlanendtime) {
            $res['sch_planendtime'] = $this->schPlanendtime;
        }
        if (null !== $this->schPrincipal) {
            $res['sch_principal'] = $this->schPrincipal;
        }
        if (null !== $this->schRemark) {
            $res['sch_remark'] = $this->schRemark;
        }
        if (null !== $this->schStarttime) {
            $res['sch_starttime'] = $this->schStarttime;
        }
        if (null !== $this->schStatesstr) {
            $res['sch_statesstr'] = $this->schStatesstr;
        }
        if (null !== $this->schTitle) {
            $res['sch_title'] = $this->schTitle;
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
        if (isset($map['sch_customerid'])) {
            $model->schCustomerid = $map['sch_customerid'];
        }
        if (isset($map['sch_endtime'])) {
            $model->schEndtime = $map['sch_endtime'];
        }
        if (isset($map['sch_finished'])) {
            $model->schFinished = $map['sch_finished'];
        }
        if (isset($map['sch_htid'])) {
            $model->schHtid = $map['sch_htid'];
        }
        if (isset($map['sch_makeemp'])) {
            $model->schMakeemp = $map['sch_makeemp'];
        }
        if (isset($map['sch_number'])) {
            $model->schNumber = $map['sch_number'];
        }
        if (isset($map['sch_planendtime'])) {
            $model->schPlanendtime = $map['sch_planendtime'];
        }
        if (isset($map['sch_principal'])) {
            $model->schPrincipal = $map['sch_principal'];
        }
        if (isset($map['sch_remark'])) {
            $model->schRemark = $map['sch_remark'];
        }
        if (isset($map['sch_starttime'])) {
            $model->schStarttime = $map['sch_starttime'];
        }
        if (isset($map['sch_statesstr'])) {
            $model->schStatesstr = $map['sch_statesstr'];
        }
        if (isset($map['sch_title'])) {
            $model->schTitle = $map['sch_title'];
        }

        return $model;
    }
}
