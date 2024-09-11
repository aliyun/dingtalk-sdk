<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenUserSubAdminDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $deptIds;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxe3d8c283bb4aa39a90f97fcb1e09
     *
     * @var string
     */
    public $dingCorpId;

    /**
     * @description This parameter is required.
     *
     * @example 211042291978xxxx
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $permissionGroupCodes;
    protected $_name = [
        'deptIds'              => 'deptIds',
        'dingCorpId'           => 'dingCorpId',
        'dingUserId'           => 'dingUserId',
        'permissionGroupCodes' => 'permissionGroupCodes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->permissionGroupCodes) {
            $res['permissionGroupCodes'] = $this->permissionGroupCodes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenUserSubAdminDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['permissionGroupCodes'])) {
            if (!empty($map['permissionGroupCodes'])) {
                $model->permissionGroupCodes = $map['permissionGroupCodes'];
            }
        }

        return $model;
    }
}
