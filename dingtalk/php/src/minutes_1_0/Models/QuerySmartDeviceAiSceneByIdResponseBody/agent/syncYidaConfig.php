<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent;

use AlibabaCloud\Tea\Model;

class syncYidaConfig extends Model
{
    /**
     * @var string
     */
    public $appCode;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $formName;

    /**
     * @var string
     */
    public $formUuid;

    /**
     * @var bool
     */
    public $syncYida;
    protected $_name = [
        'appCode' => 'appCode',
        'corpId' => 'corpId',
        'formName' => 'formName',
        'formUuid' => 'formUuid',
        'syncYida' => 'syncYida',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appCode) {
            $res['appCode'] = $this->appCode;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->formName) {
            $res['formName'] = $this->formName;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->syncYida) {
            $res['syncYida'] = $this->syncYida;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return syncYidaConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appCode'])) {
            $model->appCode = $map['appCode'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['formName'])) {
            $model->formName = $map['formName'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['syncYida'])) {
            $model->syncYida = $map['syncYida'];
        }

        return $model;
    }
}
