<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsExtractTaskRequest\contractFile;
use AlibabaCloud\Tea\Model;

class CreateContractAppsExtractTaskRequest extends Model
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
     * @var string[]
     */
    public $extractKeys;

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
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'contractFile' => 'contractFile',
        'contractFileDownloadUrl' => 'contractFileDownloadUrl',
        'contractFileName' => 'contractFileName',
        'extractKeys' => 'extractKeys',
        'fileSource' => 'fileSource',
        'requestId' => 'requestId',
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
        if (null !== $this->extractKeys) {
            $res['extractKeys'] = $this->extractKeys;
        }
        if (null !== $this->fileSource) {
            $res['fileSource'] = $this->fileSource;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateContractAppsExtractTaskRequest
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
        if (isset($map['extractKeys'])) {
            if (!empty($map['extractKeys'])) {
                $model->extractKeys = $map['extractKeys'];
            }
        }
        if (isset($map['fileSource'])) {
            $model->fileSource = $map['fileSource'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
