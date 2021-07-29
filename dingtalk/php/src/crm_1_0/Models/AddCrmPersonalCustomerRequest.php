<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCrmPersonalCustomerRequest\permission;
use AlibabaCloud\Tea\Model;

class AddCrmPersonalCustomerRequest extends Model
{
    /**
     * @description 记录创建人的用户ID
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 记录创建人的昵称
     *
     * @var string
     */
    public $creatorNick;

    /**
     * @description 数据内容
     *
     * @var mixed[]
     */
    public $data;

    /**
     * @description 扩展数据内容
     *
     * @var mixed[]
     */
    public $extendData;

    /**
     * @description 权限
     *
     * @var permission
     */
    public $permission;

    /**
     * @description 跳过uk查重
     *
     * @var bool
     */
    public $skipDuplicateCheck;
    protected $_name = [
        'creatorUserId'      => 'creatorUserId',
        'creatorNick'        => 'creatorNick',
        'data'               => 'data',
        'extendData'         => 'extendData',
        'permission'         => 'permission',
        'skipDuplicateCheck' => 'skipDuplicateCheck',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->creatorNick) {
            $res['creatorNick'] = $this->creatorNick;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = $this->extendData;
        }
        if (null !== $this->permission) {
            $res['permission'] = null !== $this->permission ? $this->permission->toMap() : null;
        }
        if (null !== $this->skipDuplicateCheck) {
            $res['skipDuplicateCheck'] = $this->skipDuplicateCheck;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCrmPersonalCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['creatorNick'])) {
            $model->creatorNick = $map['creatorNick'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['extendData'])) {
            $model->extendData = $map['extendData'];
        }
        if (isset($map['permission'])) {
            $model->permission = permission::fromMap($map['permission']);
        }
        if (isset($map['skipDuplicateCheck'])) {
            $model->skipDuplicateCheck = $map['skipDuplicateCheck'];
        }

        return $model;
    }
}
