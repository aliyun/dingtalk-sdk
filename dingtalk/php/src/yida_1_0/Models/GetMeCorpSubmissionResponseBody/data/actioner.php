<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetMeCorpSubmissionResponseBody\data;

use AlibabaCloud\Tea\Model;

class actioner extends Model
{
    /**
     * @var string
     */
    public $buName;

    /**
     * @var string
     */
    public $email;

    /**
     * @var string
     */
    public $employeeType;

    /**
     * @var string
     */
    public $employeeTypeInformation;

    /**
     * @var string
     */
    public $humanResourceGroupWorkNumber;

    /**
     * @var bool
     */
    public $isSystemAdmin;

    /**
     * @var string
     */
    public $level;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $nickName;

    /**
     * @var string
     */
    public $orderNumber;

    /**
     * @var string
     */
    public $personalPhoto;

    /**
     * @var string
     */
    public $personalPhotoUrl;

    /**
     * @var string
     */
    public $pinyinNameAll;

    /**
     * @var string
     */
    public $pinyinNickName;

    /**
     * @var string
     */
    public $state;

    /**
     * @var string
     */
    public $superUserId;

    /**
     * @var string
     */
    public $tbWang;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'buName'                       => 'buName',
        'email'                        => 'email',
        'employeeType'                 => 'employeeType',
        'employeeTypeInformation'      => 'employeeTypeInformation',
        'humanResourceGroupWorkNumber' => 'humanResourceGroupWorkNumber',
        'isSystemAdmin'                => 'isSystemAdmin',
        'level'                        => 'level',
        'name'                         => 'name',
        'nickName'                     => 'nickName',
        'orderNumber'                  => 'orderNumber',
        'personalPhoto'                => 'personalPhoto',
        'personalPhotoUrl'             => 'personalPhotoUrl',
        'pinyinNameAll'                => 'pinyinNameAll',
        'pinyinNickName'               => 'pinyinNickName',
        'state'                        => 'state',
        'superUserId'                  => 'superUserId',
        'tbWang'                       => 'tbWang',
        'userId'                       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->buName) {
            $res['buName'] = $this->buName;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->employeeType) {
            $res['employeeType'] = $this->employeeType;
        }
        if (null !== $this->employeeTypeInformation) {
            $res['employeeTypeInformation'] = $this->employeeTypeInformation;
        }
        if (null !== $this->humanResourceGroupWorkNumber) {
            $res['humanResourceGroupWorkNumber'] = $this->humanResourceGroupWorkNumber;
        }
        if (null !== $this->isSystemAdmin) {
            $res['isSystemAdmin'] = $this->isSystemAdmin;
        }
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->orderNumber) {
            $res['orderNumber'] = $this->orderNumber;
        }
        if (null !== $this->personalPhoto) {
            $res['personalPhoto'] = $this->personalPhoto;
        }
        if (null !== $this->personalPhotoUrl) {
            $res['personalPhotoUrl'] = $this->personalPhotoUrl;
        }
        if (null !== $this->pinyinNameAll) {
            $res['pinyinNameAll'] = $this->pinyinNameAll;
        }
        if (null !== $this->pinyinNickName) {
            $res['pinyinNickName'] = $this->pinyinNickName;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->superUserId) {
            $res['superUserId'] = $this->superUserId;
        }
        if (null !== $this->tbWang) {
            $res['tbWang'] = $this->tbWang;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['buName'])) {
            $model->buName = $map['buName'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['employeeType'])) {
            $model->employeeType = $map['employeeType'];
        }
        if (isset($map['employeeTypeInformation'])) {
            $model->employeeTypeInformation = $map['employeeTypeInformation'];
        }
        if (isset($map['humanResourceGroupWorkNumber'])) {
            $model->humanResourceGroupWorkNumber = $map['humanResourceGroupWorkNumber'];
        }
        if (isset($map['isSystemAdmin'])) {
            $model->isSystemAdmin = $map['isSystemAdmin'];
        }
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['orderNumber'])) {
            $model->orderNumber = $map['orderNumber'];
        }
        if (isset($map['personalPhoto'])) {
            $model->personalPhoto = $map['personalPhoto'];
        }
        if (isset($map['personalPhotoUrl'])) {
            $model->personalPhotoUrl = $map['personalPhotoUrl'];
        }
        if (isset($map['pinyinNameAll'])) {
            $model->pinyinNameAll = $map['pinyinNameAll'];
        }
        if (isset($map['pinyinNickName'])) {
            $model->pinyinNickName = $map['pinyinNickName'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['superUserId'])) {
            $model->superUserId = $map['superUserId'];
        }
        if (isset($map['tbWang'])) {
            $model->tbWang = $map['tbWang'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
