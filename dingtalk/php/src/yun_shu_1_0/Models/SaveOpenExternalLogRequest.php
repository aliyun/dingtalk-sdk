<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyun_shu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveOpenExternalLogRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingf8d907412a586
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example yunshu
     *
     * @var string
     */
    public $logSource;

    /**
     * @description This parameter is required.
     *
     * @example terminalInfo
     *
     * @var string
     */
    public $logType;

    /**
     * @description This parameter is required.
     *
     * @example [{"date":"2023-05-10","macAddress":"34-2E-B7-AF-EA-JF","devSn":"68D1F0-B76A-5CC9-BCFC-BD7548BA","staffId":"05166141678164"}]
     *
     * @var string
     */
    public $openExt;
    protected $_name = [
        'corpId' => 'corpId',
        'logSource' => 'logSource',
        'logType' => 'logType',
        'openExt' => 'openExt',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->logSource) {
            $res['logSource'] = $this->logSource;
        }
        if (null !== $this->logType) {
            $res['logType'] = $this->logType;
        }
        if (null !== $this->openExt) {
            $res['openExt'] = $this->openExt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveOpenExternalLogRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['logSource'])) {
            $model->logSource = $map['logSource'];
        }
        if (isset($map['logType'])) {
            $model->logType = $map['logType'];
        }
        if (isset($map['openExt'])) {
            $model->openExt = $map['openExt'];
        }

        return $model;
    }
}
