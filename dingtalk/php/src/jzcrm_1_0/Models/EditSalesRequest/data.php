<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditSalesRequest;

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
    public $xshCustomerid;

    /**
     * @description 主题
     *
     * @var string
     */
    public $xshTitle;

    /**
     * @description 发现时间
     *
     * @var string
     */
    public $xshDate;

    /**
     * @description 机会编号
     *
     * @var string
     */
    public $xshNumber;

    /**
     * @description 联系人
     *
     * @var string
     */
    public $xshLxrid;

    /**
     * @description 联系方式
     *
     * @var string
     */
    public $xshLianxi;

    /**
     * @description 类型
     *
     * @var string
     */
    public $xshType;

    /**
     * @description 来源
     *
     * @var string
     */
    public $xshFrom;

    /**
     * @description 所有者
     *
     * @var string
     */
    public $xshPreside;

    /**
     * @description 提供人
     *
     * @var string
     */
    public $xshProvider;

    /**
     * @description 客户需求
     *
     * @var string
     */
    public $xshRequire;

    /**
     * @description 预计签单日
     *
     * @var string
     */
    public $xshExpdate;

    /**
     * @description 预期金额
     *
     * @var string
     */
    public $xshExpmoney;

    /**
     * @description 外币备注
     *
     * @var string
     */
    public $xshMoneynote;

    /**
     * @description 阶段
     *
     * @var string
     */
    public $xshPhase;

    /**
     * @description 可能性
     *
     * @var string
     */
    public $xshKnx;

    /**
     * @description 状态
     *
     * @var string
     */
    public $xshState;

    /**
     * @description 阶段备注
     *
     * @var string
     */
    public $xshPhasenote;
    protected $_name = [
        'dataUserid'    => 'data_userid',
        'xshCustomerid' => 'xsh_customerid',
        'xshTitle'      => 'xsh_title',
        'xshDate'       => 'xsh_date',
        'xshNumber'     => 'xsh_number',
        'xshLxrid'      => 'xsh_lxrid',
        'xshLianxi'     => 'xsh_lianxi',
        'xshType'       => 'xsh_type',
        'xshFrom'       => 'xsh_from',
        'xshPreside'    => 'xsh_preside',
        'xshProvider'   => 'xsh_provider',
        'xshRequire'    => 'xsh_require',
        'xshExpdate'    => 'xsh_expdate',
        'xshExpmoney'   => 'xsh_expmoney',
        'xshMoneynote'  => 'xsh_moneynote',
        'xshPhase'      => 'xsh_phase',
        'xshKnx'        => 'xsh_knx',
        'xshState'      => 'xsh_state',
        'xshPhasenote'  => 'xsh_phasenote',
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
        if (null !== $this->xshCustomerid) {
            $res['xsh_customerid'] = $this->xshCustomerid;
        }
        if (null !== $this->xshTitle) {
            $res['xsh_title'] = $this->xshTitle;
        }
        if (null !== $this->xshDate) {
            $res['xsh_date'] = $this->xshDate;
        }
        if (null !== $this->xshNumber) {
            $res['xsh_number'] = $this->xshNumber;
        }
        if (null !== $this->xshLxrid) {
            $res['xsh_lxrid'] = $this->xshLxrid;
        }
        if (null !== $this->xshLianxi) {
            $res['xsh_lianxi'] = $this->xshLianxi;
        }
        if (null !== $this->xshType) {
            $res['xsh_type'] = $this->xshType;
        }
        if (null !== $this->xshFrom) {
            $res['xsh_from'] = $this->xshFrom;
        }
        if (null !== $this->xshPreside) {
            $res['xsh_preside'] = $this->xshPreside;
        }
        if (null !== $this->xshProvider) {
            $res['xsh_provider'] = $this->xshProvider;
        }
        if (null !== $this->xshRequire) {
            $res['xsh_require'] = $this->xshRequire;
        }
        if (null !== $this->xshExpdate) {
            $res['xsh_expdate'] = $this->xshExpdate;
        }
        if (null !== $this->xshExpmoney) {
            $res['xsh_expmoney'] = $this->xshExpmoney;
        }
        if (null !== $this->xshMoneynote) {
            $res['xsh_moneynote'] = $this->xshMoneynote;
        }
        if (null !== $this->xshPhase) {
            $res['xsh_phase'] = $this->xshPhase;
        }
        if (null !== $this->xshKnx) {
            $res['xsh_knx'] = $this->xshKnx;
        }
        if (null !== $this->xshState) {
            $res['xsh_state'] = $this->xshState;
        }
        if (null !== $this->xshPhasenote) {
            $res['xsh_phasenote'] = $this->xshPhasenote;
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
        if (isset($map['xsh_customerid'])) {
            $model->xshCustomerid = $map['xsh_customerid'];
        }
        if (isset($map['xsh_title'])) {
            $model->xshTitle = $map['xsh_title'];
        }
        if (isset($map['xsh_date'])) {
            $model->xshDate = $map['xsh_date'];
        }
        if (isset($map['xsh_number'])) {
            $model->xshNumber = $map['xsh_number'];
        }
        if (isset($map['xsh_lxrid'])) {
            $model->xshLxrid = $map['xsh_lxrid'];
        }
        if (isset($map['xsh_lianxi'])) {
            $model->xshLianxi = $map['xsh_lianxi'];
        }
        if (isset($map['xsh_type'])) {
            $model->xshType = $map['xsh_type'];
        }
        if (isset($map['xsh_from'])) {
            $model->xshFrom = $map['xsh_from'];
        }
        if (isset($map['xsh_preside'])) {
            $model->xshPreside = $map['xsh_preside'];
        }
        if (isset($map['xsh_provider'])) {
            $model->xshProvider = $map['xsh_provider'];
        }
        if (isset($map['xsh_require'])) {
            $model->xshRequire = $map['xsh_require'];
        }
        if (isset($map['xsh_expdate'])) {
            $model->xshExpdate = $map['xsh_expdate'];
        }
        if (isset($map['xsh_expmoney'])) {
            $model->xshExpmoney = $map['xsh_expmoney'];
        }
        if (isset($map['xsh_moneynote'])) {
            $model->xshMoneynote = $map['xsh_moneynote'];
        }
        if (isset($map['xsh_phase'])) {
            $model->xshPhase = $map['xsh_phase'];
        }
        if (isset($map['xsh_knx'])) {
            $model->xshKnx = $map['xsh_knx'];
        }
        if (isset($map['xsh_state'])) {
            $model->xshState = $map['xsh_state'];
        }
        if (isset($map['xsh_phasenote'])) {
            $model->xshPhasenote = $map['xsh_phasenote'];
        }

        return $model;
    }
}
