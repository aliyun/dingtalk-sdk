<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenUserAdminDTO extends Model
{
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
    protected $_name = [
        'dingCorpId' => 'dingCorpId',
        'dingUserId' => 'dingUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenUserAdminDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }

        return $model;
    }
}
