<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponseBody\data\modifyUser;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponseBody\data\originator;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 2018-01-24 11:22:01
     *
     * @var string
     */
    public $createdTimeGMT;

    /**
     * @example 1731234567
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @example 1002
     *
     * @var int
     */
    public $dataId;

    /**
     * @example {"numberField_jcr0069o":1,"multiSelectField_jcr0069s":["选项三","选项二"],"textareaField_jcr0069n":"duohang","employeeField_jcr0069x":["xxxx"],"departmentField_jcr0069z":"xxxx","cascadeDate_jcr0069u":["1514736000000","1517328000000"],"cascadeSelectField_jcr006a0":["part","part_b"],"tableField_jcr006a1":[{"departmentField_jcr006ad":"xxxx","cascadeDate_jcr006aa":["1514736000000","1517328000000"],"selectField_jcr006a6":"选项三","citySelectField_jcr006ac":["天津","天津市","河东区"],"radioField_jcr006a5":"选项二","employeeField_jcr006ab":["xxxxxx","yyyyyy"],"dateField_jcr006a9":1517328000000,"textField_jcr006a2":"明细下单行","textareaField_jcr006a3":"明细下多行","cascadeSelectField_jcr006ae":["product","product_a"],"numberField_jcr006a4":2,"checkboxField_jcr006a7":["选项一","选项三","选项二"],"multiSelectField_jcr006a8":["选项一","选项三","选项二"]}],"selectField_jcr0069q":"选项一","citySelectField_jcr0069y":["北京","北京市","东城区"],"checkboxField_jcr0069r":["选项三","选项二"],"textField_jcr0069m":"danhang","radioField_jcr0069p":"选项一","dateField_jcr0069t":1516636800000}
     *
     * @var mixed[]
     */
    public $formData;

    /**
     * @example FINST-BNKJDRF
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @example FORM-EF6Y93URN24F1SCX15VA2P918LPEIJ2H3UFORCJ1
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example {"textField":"124"}
     *
     * @var string
     */
    public $instanceValue;

    /**
     * @var string
     */
    public $modelUuid;

    /**
     * @example 2018-01-24 11:22:01
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @example 1731234567
     *
     * @var string
     */
    public $modifierUserId;

    /**
     * @var modifyUser
     */
    public $modifyUser;

    /**
     * @var originator
     */
    public $originator;

    /**
     * @example Squence-XXX
     *
     * @var string
     */
    public $sequence;

    /**
     * @example 1234
     *
     * @var string
     */
    public $serialNo;

    /**
     * @example 张三发起的表单
     *
     * @var string
     */
    public $title;

    /**
     * @example 3
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'createdTimeGMT'  => 'createdTimeGMT',
        'creatorUserId'   => 'creatorUserId',
        'dataId'          => 'dataId',
        'formData'        => 'formData',
        'formInstanceId'  => 'formInstanceId',
        'formUuid'        => 'formUuid',
        'instanceValue'   => 'instanceValue',
        'modelUuid'       => 'modelUuid',
        'modifiedTimeGMT' => 'modifiedTimeGMT',
        'modifierUserId'  => 'modifierUserId',
        'modifyUser'      => 'modifyUser',
        'originator'      => 'originator',
        'sequence'        => 'sequence',
        'serialNo'        => 'serialNo',
        'title'           => 'title',
        'version'         => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdTimeGMT) {
            $res['createdTimeGMT'] = $this->createdTimeGMT;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->dataId) {
            $res['dataId'] = $this->dataId;
        }
        if (null !== $this->formData) {
            $res['formData'] = $this->formData;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->instanceValue) {
            $res['instanceValue'] = $this->instanceValue;
        }
        if (null !== $this->modelUuid) {
            $res['modelUuid'] = $this->modelUuid;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->modifierUserId) {
            $res['modifierUserId'] = $this->modifierUserId;
        }
        if (null !== $this->modifyUser) {
            $res['modifyUser'] = null !== $this->modifyUser ? $this->modifyUser->toMap() : null;
        }
        if (null !== $this->originator) {
            $res['originator'] = null !== $this->originator ? $this->originator->toMap() : null;
        }
        if (null !== $this->sequence) {
            $res['sequence'] = $this->sequence;
        }
        if (null !== $this->serialNo) {
            $res['serialNo'] = $this->serialNo;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
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
        if (isset($map['createdTimeGMT'])) {
            $model->createdTimeGMT = $map['createdTimeGMT'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['dataId'])) {
            $model->dataId = $map['dataId'];
        }
        if (isset($map['formData'])) {
            $model->formData = $map['formData'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['instanceValue'])) {
            $model->instanceValue = $map['instanceValue'];
        }
        if (isset($map['modelUuid'])) {
            $model->modelUuid = $map['modelUuid'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['modifierUserId'])) {
            $model->modifierUserId = $map['modifierUserId'];
        }
        if (isset($map['modifyUser'])) {
            $model->modifyUser = modifyUser::fromMap($map['modifyUser']);
        }
        if (isset($map['originator'])) {
            $model->originator = originator::fromMap($map['originator']);
        }
        if (isset($map['sequence'])) {
            $model->sequence = $map['sequence'];
        }
        if (isset($map['serialNo'])) {
            $model->serialNo = $map['serialNo'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
