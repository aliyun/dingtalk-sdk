<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody\owners\masterDataDepartments;
use AlibabaCloud\Tea\Model;

class owners extends Model
{
    /**
     * @description userInfo
     *
     * @var string
     */
    public $userInfo;

    /**
     * @description tbWang
     *
     * @var string
     */
    public $tbWang;

    /**
     * @description orderNum
     *
     * @var string
     */
    public $orderNumber;

    /**
     * @description departmentDescription
     *
     * @var string
     */
    public $departmentDescription;

    /**
     * @description displayName
     *
     * @var string
     */
    public $displayName;

    /**
     * @description masterDataDepartments
     *
     * @var masterDataDepartments[]
     */
    public $masterDataDepartments;

    /**
     * @description displayEnName
     *
     * @var string
     */
    public $displayEnName;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description personalPhoto
     *
     * @var string
     */
    public $personalPhoto;

    /**
     * @description status
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'userInfo'              => 'userInfo',
        'tbWang'                => 'tbWang',
        'orderNumber'           => 'orderNumber',
        'departmentDescription' => 'departmentDescription',
        'displayName'           => 'displayName',
        'masterDataDepartments' => 'masterDataDepartments',
        'displayEnName'         => 'displayEnName',
        'userId'                => 'userId',
        'personalPhoto'         => 'personalPhoto',
        'status'                => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userInfo) {
            $res['userInfo'] = $this->userInfo;
        }
        if (null !== $this->tbWang) {
            $res['tbWang'] = $this->tbWang;
        }
        if (null !== $this->orderNumber) {
            $res['orderNumber'] = $this->orderNumber;
        }
        if (null !== $this->departmentDescription) {
            $res['departmentDescription'] = $this->departmentDescription;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->masterDataDepartments) {
            $res['masterDataDepartments'] = [];
            if (null !== $this->masterDataDepartments && \is_array($this->masterDataDepartments)) {
                $n = 0;
                foreach ($this->masterDataDepartments as $item) {
                    $res['masterDataDepartments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->displayEnName) {
            $res['displayEnName'] = $this->displayEnName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->personalPhoto) {
            $res['personalPhoto'] = $this->personalPhoto;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return owners
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userInfo'])) {
            $model->userInfo = $map['userInfo'];
        }
        if (isset($map['tbWang'])) {
            $model->tbWang = $map['tbWang'];
        }
        if (isset($map['orderNumber'])) {
            $model->orderNumber = $map['orderNumber'];
        }
        if (isset($map['departmentDescription'])) {
            $model->departmentDescription = $map['departmentDescription'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['masterDataDepartments'])) {
            if (!empty($map['masterDataDepartments'])) {
                $model->masterDataDepartments = [];
                $n                            = 0;
                foreach ($map['masterDataDepartments'] as $item) {
                    $model->masterDataDepartments[$n++] = null !== $item ? masterDataDepartments::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['displayEnName'])) {
            $model->displayEnName = $map['displayEnName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['personalPhoto'])) {
            $model->personalPhoto = $map['personalPhoto'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
