<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrintDictionaryRequest extends Model
{
    /**
     * @description 应用代码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 表单id
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 版本
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
