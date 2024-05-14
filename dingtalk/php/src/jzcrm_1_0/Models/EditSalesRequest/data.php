<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditSalesRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $xshCustomerid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $xshDate;

    /**
     * @var string
     */
    public $xshExpdate;

    /**
     * @var string
     */
    public $xshExpmoney;

    /**
     * @var string
     */
    public $xshFrom;

    /**
     * @var string
     */
    public $xshKnx;

    /**
     * @var string
     */
    public $xshLianxi;

    /**
     * @var string
     */
    public $xshLxrid;

    /**
     * @var string
     */
    public $xshMoneynote;

    /**
     * @var string
     */
    public $xshNumber;

    /**
     * @var string
     */
    public $xshPhase;

    /**
     * @var string
     */
    public $xshPhasenote;

    /**
     * @var string
     */
    public $xshPreside;

    /**
     * @var string
     */
    public $xshProvider;

    /**
     * @var string
     */
    public $xshRequire;

    /**
     * @var string
     */
    public $xshState;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $xshTitle;

    /**
     * @var string
     */
    public $xshType;
    protected $_name = [
        'dataUserid'    => 'data_userid',
        'xshCustomerid' => 'xsh_customerid',
        'xshDate'       => 'xsh_date',
        'xshExpdate'    => 'xsh_expdate',
        'xshExpmoney'   => 'xsh_expmoney',
        'xshFrom'       => 'xsh_from',
        'xshKnx'        => 'xsh_knx',
        'xshLianxi'     => 'xsh_lianxi',
        'xshLxrid'      => 'xsh_lxrid',
        'xshMoneynote'  => 'xsh_moneynote',
        'xshNumber'     => 'xsh_number',
        'xshPhase'      => 'xsh_phase',
        'xshPhasenote'  => 'xsh_phasenote',
        'xshPreside'    => 'xsh_preside',
        'xshProvider'   => 'xsh_provider',
        'xshRequire'    => 'xsh_require',
        'xshState'      => 'xsh_state',
        'xshTitle'      => 'xsh_title',
        'xshType'       => 'xsh_type',
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
        if (null !== $this->xshDate) {
            $res['xsh_date'] = $this->xshDate;
        }
        if (null !== $this->xshExpdate) {
            $res['xsh_expdate'] = $this->xshExpdate;
        }
        if (null !== $this->xshExpmoney) {
            $res['xsh_expmoney'] = $this->xshExpmoney;
        }
        if (null !== $this->xshFrom) {
            $res['xsh_from'] = $this->xshFrom;
        }
        if (null !== $this->xshKnx) {
            $res['xsh_knx'] = $this->xshKnx;
        }
        if (null !== $this->xshLianxi) {
            $res['xsh_lianxi'] = $this->xshLianxi;
        }
        if (null !== $this->xshLxrid) {
            $res['xsh_lxrid'] = $this->xshLxrid;
        }
        if (null !== $this->xshMoneynote) {
            $res['xsh_moneynote'] = $this->xshMoneynote;
        }
        if (null !== $this->xshNumber) {
            $res['xsh_number'] = $this->xshNumber;
        }
        if (null !== $this->xshPhase) {
            $res['xsh_phase'] = $this->xshPhase;
        }
        if (null !== $this->xshPhasenote) {
            $res['xsh_phasenote'] = $this->xshPhasenote;
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
        if (null !== $this->xshState) {
            $res['xsh_state'] = $this->xshState;
        }
        if (null !== $this->xshTitle) {
            $res['xsh_title'] = $this->xshTitle;
        }
        if (null !== $this->xshType) {
            $res['xsh_type'] = $this->xshType;
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
        if (isset($map['xsh_date'])) {
            $model->xshDate = $map['xsh_date'];
        }
        if (isset($map['xsh_expdate'])) {
            $model->xshExpdate = $map['xsh_expdate'];
        }
        if (isset($map['xsh_expmoney'])) {
            $model->xshExpmoney = $map['xsh_expmoney'];
        }
        if (isset($map['xsh_from'])) {
            $model->xshFrom = $map['xsh_from'];
        }
        if (isset($map['xsh_knx'])) {
            $model->xshKnx = $map['xsh_knx'];
        }
        if (isset($map['xsh_lianxi'])) {
            $model->xshLianxi = $map['xsh_lianxi'];
        }
        if (isset($map['xsh_lxrid'])) {
            $model->xshLxrid = $map['xsh_lxrid'];
        }
        if (isset($map['xsh_moneynote'])) {
            $model->xshMoneynote = $map['xsh_moneynote'];
        }
        if (isset($map['xsh_number'])) {
            $model->xshNumber = $map['xsh_number'];
        }
        if (isset($map['xsh_phase'])) {
            $model->xshPhase = $map['xsh_phase'];
        }
        if (isset($map['xsh_phasenote'])) {
            $model->xshPhasenote = $map['xsh_phasenote'];
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
        if (isset($map['xsh_state'])) {
            $model->xshState = $map['xsh_state'];
        }
        if (isset($map['xsh_title'])) {
            $model->xshTitle = $map['xsh_title'];
        }
        if (isset($map['xsh_type'])) {
            $model->xshType = $map['xsh_type'];
        }

        return $model;
    }
}
