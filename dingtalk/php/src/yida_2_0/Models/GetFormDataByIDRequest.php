<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetFormDataByIDRequest extends Model
{
    /**
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appType;

    /**
     * @example FORM-AA28579F69644FC19A47FE267457E664ZVR1
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @example hexxx
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example false
     *
     * @var bool
     */
    public $useAlias;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'     => 'appType',
        'formUuid'    => 'formUuid',
        'language'    => 'language',
        'systemToken' => 'systemToken',
        'useAlias'    => 'useAlias',
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
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->useAlias) {
            $res['useAlias'] = $this->useAlias;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFormDataByIDRequest
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
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['useAlias'])) {
            $model->useAlias = $map['useAlias'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
