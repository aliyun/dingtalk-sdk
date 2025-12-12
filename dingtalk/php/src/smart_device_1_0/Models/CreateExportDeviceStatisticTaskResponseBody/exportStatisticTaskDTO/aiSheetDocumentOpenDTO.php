<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateExportDeviceStatisticTaskResponseBody\exportStatisticTaskDTO;

use AlibabaCloud\Tea\Model;

class aiSheetDocumentOpenDTO extends Model
{
    /**
     * @var int
     */
    public $aiSheetTemplateId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $documentId;

    /**
     * @var string
     */
    public $documentName;

    /**
     * @var string
     */
    public $documentUrl;
    protected $_name = [
        'aiSheetTemplateId' => 'aiSheetTemplateId',
        'corpId' => 'corpId',
        'documentId' => 'documentId',
        'documentName' => 'documentName',
        'documentUrl' => 'documentUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiSheetTemplateId) {
            $res['aiSheetTemplateId'] = $this->aiSheetTemplateId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->documentId) {
            $res['documentId'] = $this->documentId;
        }
        if (null !== $this->documentName) {
            $res['documentName'] = $this->documentName;
        }
        if (null !== $this->documentUrl) {
            $res['documentUrl'] = $this->documentUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aiSheetDocumentOpenDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aiSheetTemplateId'])) {
            $model->aiSheetTemplateId = $map['aiSheetTemplateId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['documentId'])) {
            $model->documentId = $map['documentId'];
        }
        if (isset($map['documentName'])) {
            $model->documentName = $map['documentName'];
        }
        if (isset($map['documentUrl'])) {
            $model->documentUrl = $map['documentUrl'];
        }

        return $model;
    }
}
