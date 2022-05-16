<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesTeamMgmtResponseBody\result;
use AlibabaCloud\Tea\Model;

class IndustryManufactureMesTeamMgmtResponseBody extends Model
{
    /**
     * @var int
     */
    public $dingOpenErrcode;

    /**
     * @var string
     */
    public $errorMsg;

    /**
     * @var result
     */
    public $result;
    protected $_name = [
        'dingOpenErrcode' => 'dingOpenErrcode',
        'errorMsg'        => 'errorMsg',
        'result'          => 'result',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingOpenErrcode) {
            $res['dingOpenErrcode'] = $this->dingOpenErrcode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->result) {
            $res['result'] = null !== $this->result ? $this->result->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesTeamMgmtResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingOpenErrcode'])) {
            $model->dingOpenErrcode = $map['dingOpenErrcode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }

        return $model;
    }
}
