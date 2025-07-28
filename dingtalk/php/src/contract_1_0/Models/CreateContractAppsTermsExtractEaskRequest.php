<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsTermsExtractEaskRequest\contractFile;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsTermsExtractEaskRequest\extractRules;
use AlibabaCloud\Tea\Model;

class CreateContractAppsTermsExtractEaskRequest extends Model
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
     * @var string
     */
    public $contractFileName;

    /**
     * @var extractRules[]
     */
    public $extractRules;

    /**
     * @var string
     */
    public $fileSource;

    /**
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
        'extractRules' => 'extractRules',
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
        if (null !== $this->extractRules) {
            $res['extractRules'] = [];
            if (null !== $this->extractRules && \is_array($this->extractRules)) {
                $n = 0;
                foreach ($this->extractRules as $item) {
                    $res['extractRules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
     * @return CreateContractAppsTermsExtractEaskRequest
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
        if (isset($map['extractRules'])) {
            if (!empty($map['extractRules'])) {
                $model->extractRules = [];
                $n = 0;
                foreach ($map['extractRules'] as $item) {
                    $model->extractRules[$n++] = null !== $item ? extractRules::fromMap($item) : $item;
                }
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
