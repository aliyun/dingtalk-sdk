<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrintDictionaryRequest extends Model
{
    /**
     * @example APP_XABJJSJ
     *
     * @var string
     */
    public $appType;

    /**
     * @example FORM-XABJJSJ
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example abfefw
     *
     * @var string
     */
    public $userId;

    /**
     * @example 0
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'appType'  => 'appType',
        'formUuid' => 'formUuid',
        'userId'   => 'userId',
        'version'  => 'version',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrintDictionaryRequest
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
