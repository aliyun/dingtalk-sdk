<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryFileProcessResultResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $downloadUrl;

    /**
     * @var string
     */
    public $pdfStatus;

    /**
     * @var string
     */
    public $renderTaskId;
    protected $_name = [
        'downloadUrl' => 'downloadUrl',
        'pdfStatus' => 'pdfStatus',
        'renderTaskId' => 'renderTaskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->pdfStatus) {
            $res['pdfStatus'] = $this->pdfStatus;
        }
        if (null !== $this->renderTaskId) {
            $res['renderTaskId'] = $this->renderTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['pdfStatus'])) {
            $model->pdfStatus = $map['pdfStatus'];
        }
        if (isset($map['renderTaskId'])) {
            $model->renderTaskId = $map['renderTaskId'];
        }

        return $model;
    }
}
