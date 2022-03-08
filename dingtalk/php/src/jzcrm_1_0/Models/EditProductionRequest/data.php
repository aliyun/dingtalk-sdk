<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditProductionRequest;

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
     * @description 对应客户
     *
     * @var string
     */
    public $schCustomerid;

    /**
     * @description 完成日期
     *
     * @var string
     */
    public $schEndtime;

    /**
     * @description 状态（未生产，生产中，生产中止，生产完成）
     *
     * @var string
     */
    public $schFinished;

    /**
     * @description 订单
     *
     * @var string
     */
    public $schHtid;

    /**
     * @description 生产人员
     *
     * @var string
     */
    public $schMakeemp;

    /**
     * @description 单号
     *
     * @var string
     */
    public $schNumber;

    /**
     * @description 计划完成
     *
     * @var string
     */
    public $schPlanendtime;

    /**
     * @description 负责人
     *
     * @var string
     */
    public $schPrincipal;

    /**
     * @description 备注
     *
     * @var string
     */
    public $schRemark;

    /**
     * @description 开始日期
     *
     * @var string
     */
    public $schStarttime;

    /**
     * @description 阶段（计划，审核，领料，生产，验收，入库/退料，结单，取消）
     *
     * @var string
     */
    public $schStatesstr;

    /**
     * @description 主题
     *
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
