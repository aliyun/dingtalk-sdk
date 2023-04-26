<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody\owners\masterDataDepartments;
use AlibabaCloud\Tea\Model;

class owners extends Model
{
    /**
     * @var string
     */
    public $departmentDescription;

    /**
     * @var string
     */
    public $displayEnName;

    /**
     * @var string
     */
    public $displayName;

    /**
     * @var masterDataDepartments[]
     */
    public $masterDataDepartments;

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
    public $status;

    /**
     * @var string
     */
    public $tbWang;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userInfo;
    protected $_name = [
        'departmentDescription' => 'departmentDescription',
        'displayEnName'         => 'displayEnName',
        'displayName'           => 'displayName',
        'masterDataDepartments' => 'masterDataDepartments',
        'orderNumber'           => 'orderNumber',
        'personalPhoto'         => 'personalPhoto',
        'status'                => 'status',
        'tbWang'                => 'tbWang',
        'userId'                => 'userId',
        'userInfo'              => 'userInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentDescription) {
            $res['departmentDescription'] = $this->departmentDescription;
        }
        if (null !== $this->displayEnName) {
            $res['displayEnName'] = $this->displayEnName;
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
        if (null !== $this->orderNumber) {
            $res['orderNumber'] = $this->orderNumber;
        }
        if (null !== $this->personalPhoto) {
            $res['personalPhoto'] = $this->personalPhoto;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->tbWang) {
            $res['tbWang'] = $this->tbWang;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userInfo) {
            $res['userInfo'] = $this->userInfo;
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
        if (isset($map['departmentDescription'])) {
            $model->departmentDescription = $map['departmentDescription'];
        }
        if (isset($map['displayEnName'])) {
            $model->displayEnName = $map['displayEnName'];
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
        if (isset($map['orderNumber'])) {
            $model->orderNumber = $map['orderNumber'];
        }
        if (isset($map['personalPhoto'])) {
            $model->personalPhoto = $map['personalPhoto'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['tbWang'])) {
            $model->tbWang = $map['tbWang'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userInfo'])) {
            $model->userInfo = $map['userInfo'];
        }

        return $model;
    }
}
