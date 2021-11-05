<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrintDictionaryRequest extends Model
{
    /**
     * @description 表单id
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 应用代码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 版本
     *
     * @var int
     */
    public $version;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'formUuid' => 'formUuid',
        'appType'  => 'appType',
        'version'  => 'version',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
