<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsResponseBody\result\domainList;

use AlibabaCloud\Tea\Model;

class operatorAgentIdList extends Model
{
    /**
     * @example 开发部成立于2000年
     *
     * @var string
     */
    public $departmentDescription;

    /**
     * @example 测试应用
     *
     * @var string
     */
    public $displayName;

    /**
     * @example ZhangSan
     *
     * @var string
     */
    public $displayNameInEnglish;

    /**
     * @example o-YDJKINSSDLLND
     *
     * @var string
     */
    public $orderNumber;

    /**
     * @example https://abc.com/a.png
     *
     * @var string
     */
    public $personalPhoto;

    /**
     * @example running
     *
     * @var string
     */
    public $status;

    /**
     * @example ding173982232112232
     *
     * @var string
     */
    public $userId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $userInformation;
    protected $_name = [
        'departmentDescription' => 'departmentDescription',
        'displayName' => 'displayName',
        'displayNameInEnglish' => 'displayNameInEnglish',
        'orderNumber' => 'orderNumber',
        'personalPhoto' => 'personalPhoto',
        'status' => 'status',
        'userId' => 'userId',
        'userInformation' => 'userInformation',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentDescription) {
            $res['departmentDescription'] = $this->departmentDescription;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->displayNameInEnglish) {
            $res['displayNameInEnglish'] = $this->displayNameInEnglish;
        }
        if (null !== $this->orderNumber) {
            $res['orderNumber'] = $this->orderNumber;
        }
        if (null !== $this->personalPhoto) {
            $res['personalPhoto'] = $this->personalPhoto;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userInformation) {
            $res['userInformation'] = $this->userInformation;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return operatorAgentIdList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentDescription'])) {
            $model->departmentDescription = $map['departmentDescription'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['displayNameInEnglish'])) {
            $model->displayNameInEnglish = $map['displayNameInEnglish'];
        }
        if (isset($map['orderNumber'])) {
            $model->orderNumber = $map['orderNumber'];
        }
        if (isset($map['personalPhoto'])) {
            $model->personalPhoto = $map['personalPhoto'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userInformation'])) {
            $model->userInformation = $map['userInformation'];
        }

        return $model;
    }
}
