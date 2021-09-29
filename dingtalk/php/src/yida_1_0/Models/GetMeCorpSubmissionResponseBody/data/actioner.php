<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetMeCorpSubmissionResponseBody\data;

use AlibabaCloud\Tea\Model;

class actioner extends Model
{
    /**
     * @description employeeTypeInformation
     *
     * @var string
     */
    public $employeeTypeInformation;

    /**
     * @description empType
     *
     * @var string
     */
    public $employeeType;

    /**
     * @description level
     *
     * @var string
     */
    public $level;

    /**
     * @description nickName
     *
     * @var string
     */
    public $nickName;

    /**
     * @description orderNum
     *
     * @var string
     */
    public $orderNumber;

    /**
     * @description pinyinNick
     *
     * @var string
     */
    public $pinyinNickName;

    /**
     * @description superUserId
     *
     * @var string
     */
    public $superUserId;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description buName
     *
     * @var string
     */
    public $buName;

    /**
     * @description tbWang
     *
     * @var string
     */
    public $tbWang;

    /**
     * @description hrgWorkNo
     *
     * @var string
     */
    public $humanResourceGroupWorkNumber;

    /**
     * @description pinyinNameAll
     *
     * @var string
     */
    public $pinyinNameAll;

    /**
     * @description name
     *
     * @var string
     */
    public $name;

    /**
     * @description state
     *
     * @var string
     */
    public $state;

    /**
     * @description personalPhotoUrl
     *
     * @var string
     */
    public $personalPhotoUrl;

    /**
     * @description isSystemAdmin
     *
     * @var bool
     */
    public $isSystemAdmin;

    /**
     * @description email
     *
     * @var string
     */
    public $email;

    /**
     * @description personalPhoto
     *
     * @var string
     */
    public $personalPhoto;
    protected $_name = [
        'employeeTypeInformation'      => 'employeeTypeInformation',
        'employeeType'                 => 'employeeType',
        'level'                        => 'level',
        'nickName'                     => 'nickName',
        'orderNumber'                  => 'orderNumber',
        'pinyinNickName'               => 'pinyinNickName',
        'superUserId'                  => 'superUserId',
        'userId'                       => 'userId',
        'buName'                       => 'buName',
        'tbWang'                       => 'tbWang',
        'humanResourceGroupWorkNumber' => 'humanResourceGroupWorkNumber',
        'pinyinNameAll'                => 'pinyinNameAll',
        'name'                         => 'name',
        'state'                        => 'state',
        'personalPhotoUrl'             => 'personalPhotoUrl',
        'isSystemAdmin'                => 'isSystemAdmin',
        'email'                        => 'email',
        'personalPhoto'                => 'personalPhoto',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->employeeTypeInformation) {
            $res['employeeTypeInformation'] = $this->employeeTypeInformation;
        }
        if (null !== $this->employeeType) {
            $res['employeeType'] = $this->employeeType;
        }
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->orderNumber) {
            $res['orderNumber'] = $this->orderNumber;
        }
        if (null !== $this->pinyinNickName) {
            $res['pinyinNickName'] = $this->pinyinNickName;
        }
        if (null !== $this->superUserId) {
            $res['superUserId'] = $this->superUserId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->buName) {
            $res['buName'] = $this->buName;
        }
        if (null !== $this->tbWang) {
            $res['tbWang'] = $this->tbWang;
        }
        if (null !== $this->humanResourceGroupWorkNumber) {
            $res['humanResourceGroupWorkNumber'] = $this->humanResourceGroupWorkNumber;
        }
        if (null !== $this->pinyinNameAll) {
            $res['pinyinNameAll'] = $this->pinyinNameAll;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->personalPhotoUrl) {
            $res['personalPhotoUrl'] = $this->personalPhotoUrl;
        }
        if (null !== $this->isSystemAdmin) {
            $res['isSystemAdmin'] = $this->isSystemAdmin;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->personalPhoto) {
            $res['personalPhoto'] = $this->personalPhoto;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actioner
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['employeeTypeInformation'])) {
            $model->employeeTypeInformation = $map['employeeTypeInformation'];
        }
        if (isset($map['employeeType'])) {
            $model->employeeType = $map['employeeType'];
        }
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['orderNumber'])) {
            $model->orderNumber = $map['orderNumber'];
        }
        if (isset($map['pinyinNickName'])) {
            $model->pinyinNickName = $map['pinyinNickName'];
        }
        if (isset($map['superUserId'])) {
            $model->superUserId = $map['superUserId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['buName'])) {
            $model->buName = $map['buName'];
        }
        if (isset($map['tbWang'])) {
            $model->tbWang = $map['tbWang'];
        }
        if (isset($map['humanResourceGroupWorkNumber'])) {
            $model->humanResourceGroupWorkNumber = $map['humanResourceGroupWorkNumber'];
        }
        if (isset($map['pinyinNameAll'])) {
            $model->pinyinNameAll = $map['pinyinNameAll'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['personalPhotoUrl'])) {
            $model->personalPhotoUrl = $map['personalPhotoUrl'];
        }
        if (isset($map['isSystemAdmin'])) {
            $model->isSystemAdmin = $map['isSystemAdmin'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['personalPhoto'])) {
            $model->personalPhoto = $map['personalPhoto'];
        }

        return $model;
    }
}
