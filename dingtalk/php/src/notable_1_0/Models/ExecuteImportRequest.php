<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ExecuteImportRequest\appendConfig;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ExecuteImportRequest\encryption;
use AlibabaCloud\Tea\Model;

class ExecuteImportRequest extends Model
{
    /**
     * @var appendConfig
     */
    public $appendConfig;

    /**
     * @var encryption
     */
    public $encryption;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $importId;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'appendConfig' => 'appendConfig',
        'encryption' => 'encryption',
        'importId' => 'importId',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appendConfig) {
            $res['appendConfig'] = null !== $this->appendConfig ? $this->appendConfig->toMap() : null;
        }
        if (null !== $this->encryption) {
            $res['encryption'] = null !== $this->encryption ? $this->encryption->toMap() : null;
        }
        if (null !== $this->importId) {
            $res['importId'] = $this->importId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteImportRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appendConfig'])) {
            $model->appendConfig = appendConfig::fromMap($map['appendConfig']);
        }
        if (isset($map['encryption'])) {
            $model->encryption = encryption::fromMap($map['encryption']);
        }
        if (isset($map['importId'])) {
            $model->importId = $map['importId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
