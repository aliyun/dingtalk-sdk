<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsReviewTaskRequest\contractFile;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsReviewTaskRequest\reviewCustomRules;
use AlibabaCloud\Tea\Model;

class CreateContractAppsReviewTaskRequest extends Model
{
    /**
     * @var contractFile
     */
    public $contractFile;

    /**
     * @var string
     */
    public $contractFileDownloadUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contractFileName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileSource;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $requestId;

    /**
     * @var reviewCustomRules[]
     */
    public $reviewCustomRules;

    /**
     * @var string
     */
    public $ruleType;

    /**
     * @var string
     */
    public $standpoint;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'contractFile' => 'contractFile',
        'contractFileDownloadUrl' => 'contractFileDownloadUrl',
        'contractFileName' => 'contractFileName',
        'fileSource' => 'fileSource',
        'requestId' => 'requestId',
        'reviewCustomRules' => 'reviewCustomRules',
        'ruleType' => 'ruleType',
        'standpoint' => 'standpoint',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractFile) {
            $res['contractFile'] = null !== $this->contractFile ? $this->contractFile->toMap() : null;
        }
        if (null !== $this->contractFileDownloadUrl) {
            $res['contractFileDownloadUrl'] = $this->contractFileDownloadUrl;
        }
        if (null !== $this->contractFileName) {
            $res['contractFileName'] = $this->contractFileName;
        }
        if (null !== $this->fileSource) {
            $res['fileSource'] = $this->fileSource;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->reviewCustomRules) {
            $res['reviewCustomRules'] = [];
            if (null !== $this->reviewCustomRules && \is_array($this->reviewCustomRules)) {
                $n = 0;
                foreach ($this->reviewCustomRules as $item) {
                    $res['reviewCustomRules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ruleType) {
            $res['ruleType'] = $this->ruleType;
        }
        if (null !== $this->standpoint) {
            $res['standpoint'] = $this->standpoint;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateContractAppsReviewTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contractFile'])) {
            $model->contractFile = contractFile::fromMap($map['contractFile']);
        }
        if (isset($map['contractFileDownloadUrl'])) {
            $model->contractFileDownloadUrl = $map['contractFileDownloadUrl'];
        }
        if (isset($map['contractFileName'])) {
            $model->contractFileName = $map['contractFileName'];
        }
        if (isset($map['fileSource'])) {
            $model->fileSource = $map['fileSource'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['reviewCustomRules'])) {
            if (!empty($map['reviewCustomRules'])) {
                $model->reviewCustomRules = [];
                $n = 0;
                foreach ($map['reviewCustomRules'] as $item) {
                    $model->reviewCustomRules[$n++] = null !== $item ? reviewCustomRules::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ruleType'])) {
            $model->ruleType = $map['ruleType'];
        }
        if (isset($map['standpoint'])) {
            $model->standpoint = $map['standpoint'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
