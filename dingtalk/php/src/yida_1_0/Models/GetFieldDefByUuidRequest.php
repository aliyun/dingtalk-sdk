<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFieldDefByUuidRequest extends Model
{
    /**
     * @description 应用编码。应用唯一标识。如：APP_XXX
     *
     * @var string
     */
    public $appType;

    /**
     * @description 表单唯一标识
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 应用秘钥。在应用设置-部署运维-应用密钥中获取。
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'     => 'appType',
        'formUuid'    => 'formUuid',
        'systemToken' => 'systemToken',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFieldDefByUuidRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
