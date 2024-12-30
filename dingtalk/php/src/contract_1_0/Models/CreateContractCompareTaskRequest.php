<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractCompareTaskRequest\comparativeFile;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractCompareTaskRequest\standardFile;
use AlibabaCloud\Tea\Model;

class CreateContractCompareTaskRequest extends Model
{
    /**
     * @var comparativeFile
     */
    public $comparativeFile;

    /**
     * @var string
     */
    public $comparativeFileDownloadUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $comparativeFileName;

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
     * @var standardFile
     */
    public $standardFile;

    /**
     * @var string
     */
    public $standardFileDownloadUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $standardFileName;
    protected $_name = [
        'comparativeFile'            => 'comparativeFile',
        'comparativeFileDownloadUrl' => 'comparativeFileDownloadUrl',
        'comparativeFileName'        => 'comparativeFileName',
        'fileSource'                 => 'fileSource',
        'requestId'                  => 'requestId',
        'standardFile'               => 'standardFile',
        'standardFileDownloadUrl'    => 'standardFileDownloadUrl',
        'standardFileName'           => 'standardFileName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->comparativeFile) {
            $res['comparativeFile'] = null !== $this->comparativeFile ? $this->comparativeFile->toMap() : null;
        }
        if (null !== $this->comparativeFileDownloadUrl) {
            $res['comparativeFileDownloadUrl'] = $this->comparativeFileDownloadUrl;
        }
        if (null !== $this->comparativeFileName) {
            $res['comparativeFileName'] = $this->comparativeFileName;
        }
        if (null !== $this->fileSource) {
            $res['fileSource'] = $this->fileSource;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->standardFile) {
            $res['standardFile'] = null !== $this->standardFile ? $this->standardFile->toMap() : null;
        }
        if (null !== $this->standardFileDownloadUrl) {
            $res['standardFileDownloadUrl'] = $this->standardFileDownloadUrl;
        }
        if (null !== $this->standardFileName) {
            $res['standardFileName'] = $this->standardFileName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateContractCompareTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['comparativeFile'])) {
            $model->comparativeFile = comparativeFile::fromMap($map['comparativeFile']);
        }
        if (isset($map['comparativeFileDownloadUrl'])) {
            $model->comparativeFileDownloadUrl = $map['comparativeFileDownloadUrl'];
        }
        if (isset($map['comparativeFileName'])) {
            $model->comparativeFileName = $map['comparativeFileName'];
        }
        if (isset($map['fileSource'])) {
            $model->fileSource = $map['fileSource'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['standardFile'])) {
            $model->standardFile = standardFile::fromMap($map['standardFile']);
        }
        if (isset($map['standardFileDownloadUrl'])) {
            $model->standardFileDownloadUrl = $map['standardFileDownloadUrl'];
        }
        if (isset($map['standardFileName'])) {
            $model->standardFileName = $map['standardFileName'];
        }

        return $model;
    }
}
