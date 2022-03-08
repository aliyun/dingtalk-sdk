<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerRequest\contacts;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerRequest\permission;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerRequest\saveOption;
use AlibabaCloud\Tea\Model;

class CreateCustomerRequest extends Model
{
    /**
     * @description 关联联系人数据
     *
     * @var contacts[]
     */
    public $contacts;

    /**
     * @description 创建人的userId
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 客户实例数据（表单数据）
     *
     * @var mixed[]
     */
    public $data;

    /**
     * @description 客户实例扩展数据
     *
     * @var mixed[]
     */
    public $extendData;

    /**
     * @description 已存在客户时，添加联系人，可以传入客户的instanceId用作关联绑定
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description 写入客户类型：个人客户crm_customer_personal; 企业客户crm_customer
     *
     * @var string
     */
    public $objectType;

    /**
     * @description 权限
     *
     * @var permission
     */
    public $permission;

    /**
     * @description 保存配置项
     *
     * @var saveOption
     */
    public $saveOption;
    protected $_name = [
        'contacts'      => 'contacts',
        'creatorUserId' => 'creatorUserId',
        'data'          => 'data',
        'extendData'    => 'extendData',
        'instanceId'    => 'instanceId',
        'objectType'    => 'objectType',
        'permission'    => 'permission',
        'saveOption'    => 'saveOption',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contacts) {
            $res['contacts'] = [];
            if (null !== $this->contacts && \is_array($this->contacts)) {
                $n = 0;
                foreach ($this->contacts as $item) {
                    $res['contacts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = $this->extendData;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }
        if (null !== $this->permission) {
            $res['permission'] = null !== $this->permission ? $this->permission->toMap() : null;
        }
        if (null !== $this->saveOption) {
            $res['saveOption'] = null !== $this->saveOption ? $this->saveOption->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contacts'])) {
            if (!empty($map['contacts'])) {
                $model->contacts = [];
                $n               = 0;
                foreach ($map['contacts'] as $item) {
                    $model->contacts[$n++] = null !== $item ? contacts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['extendData'])) {
            $model->extendData = $map['extendData'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }
        if (isset($map['permission'])) {
            $model->permission = permission::fromMap($map['permission']);
        }
        if (isset($map['saveOption'])) {
            $model->saveOption = saveOption::fromMap($map['saveOption']);
        }

        return $model;
    }
}
